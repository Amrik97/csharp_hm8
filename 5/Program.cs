// 
  public override void Method1()
        {
            var n = Utility.ReadIntConsole("Введите кол-во строк");
            Utility.DisplayPascalTriangle(n);
        }

        public override string GetName()
        {
            return "Показать треугольник Паскаля. Сделать вывод в виде равнобедренного треугольника.";
        }