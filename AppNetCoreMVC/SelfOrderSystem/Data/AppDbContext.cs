using Microsoft.EntityFrameworkCore;
using SelfOrderSystem.Models;

namespace SelfOrderSystem.Data;
public class AppDbContext : DbContext {
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) {    //受け取った設定を親クラスへ渡す
    }
    // Categories テーブルを Category 型として問い合わせるためのプロパティ
    public DbSet<Category> Categories => Set<Category>();

    // Products テーブルを Product 型として問い合わせるためのプロパティ
    public DbSet<Product> Products => Set<Product>();
}