using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CarReportSystem {
    public class CarReportRepository {

        private static byte[]? ImageToBytes(Image? image) {
            if(image is null) return null;
            using var stream = new MemoryStream();
            image.Save(stream, image.RawFormat);
            return stream.ToArray();
        }

        private static Image? BytesToImage(byte[]? bytes) {
            if(bytes is null) return null;
            using var stream = new MemoryStream(bytes);
            return new Bitmap(Image.FromStream(stream));
        }


        public List<CarReport> GetAll() {
            var carReports = new List<CarReport>();
            using var connection = Database.GetConnection();
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText =
            """
            SELECT Id, Date,Author,Maker,CarName,Report,Picture
            FROM CarReports
            ORDER BY Id;
            """;

            using var reader = command.ExecuteReader();
            while(reader.Read()) {
                carReports.Add(new CarReport {
                    Id = reader.GetInt32(0),
                    Date = DateTime.Parse(reader.GetString(1)),
                    Author = reader.GetString(2),
                    Maker = (CarReport.MakerGroup)reader.GetInt32(3),
                    CarName = reader.GetString(4),
                    Report = reader.GetString(5),
                    Picture = reader.IsDBNull(6) ? null : BytesToImage((byte[])reader.GetValue(6))
                });
            }
            return carReports;
        }


        public int Add(DateTime date, string author, CarReport.MakerGroup maker, string carName, string report, Image? picture) {
            using var connection = Database.GetConnection();
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText =
                """
                INSERT INTO CarReports
                (Date,Author,Maker,CarName,Report,Picture)
                VALUES
                ($date,$author,$maker,$carName,$report,$picture);

                SELECT last_insert_rowid();
                """;

            command.Parameters.AddWithValue("$date", date.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("$author", author);
            command.Parameters.AddWithValue("$maker", (int)maker);
            command.Parameters.AddWithValue("$carName", carName);
            command.Parameters.AddWithValue("$report", report);
            command.Parameters.AddWithValue("$picture", (object?)ImageToBytes(picture) ?? DBNull.Value);

            var result = command.ExecuteScalar();

            if(result is null) {
                throw new InvalidOperationException("登録した商品のIDを取得できませんでした。");
            }
            return Convert.ToInt32((long)result);
        }


        public void Update(CarReport carReport) {
            //接続オブジェクトを生成する 
            using var connection = Database.GetConnection();
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText =
                """
            UPDATE CarReports
            SET Date = $date, Author = $author, Maker = $maker,
                CarName = $carName, Report = $report, Picture = $picture
            WHERE Id = $id;
            """;
            command.Parameters.AddWithValue("$date", carReport.Date.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("$author", carReport.Author);
            command.Parameters.AddWithValue("$maker", (int)carReport.Maker);
            command.Parameters.AddWithValue("$carName", carReport.CarName);
            command.Parameters.AddWithValue("$report", carReport.Report);
            command.Parameters.AddWithValue("$picture", (object?)ImageToBytes(carReport.Picture) ?? DBNull.Value);
            command.Parameters.AddWithValue("$id", carReport.Id);

            if(command.ExecuteNonQuery() == 0) {
                throw new InvalidOperationException("修正対象のレポートが見つかりませんでした。");
            }
        }


        public void Delete(int id) {
            using var connection = Database.GetConnection();
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText =
            """
            DELETE FROM CarReports
            WHERE Id = $id;
            """;

            command.Parameters.AddWithValue("$id", id);
            command.ExecuteNonQuery();
        }
    }
}
