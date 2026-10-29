using Excercise03;

var service = new Take20Processor();
var processor = new TextFileProcessor(service);
processor.Run("吾輩は猫である.txt");