//
     public override void Method1()
        {
            var n = Utility.ReadIntConsole("Введите кол-во строк");
            var m = Utility.ReadIntConsole("Введите кол-во столбцов");
            var matrixA = Utility.CreateMatrix(n, m);
            Utility.DisplayArr(matrixA);

            n = Utility.ReadIntConsole("Введите кол-во строк");
            m = Utility.ReadIntConsole("Введите кол-во столбцов");
            var matrixB = Utility.CreateMatrix(n, m);
            Utility.DisplayArr(matrixB);

            Console.WriteLine("Произведение матриц:");
            var matrixC = matrixA.Multiply(matrixB);
            Utility.DisplayArr(matrixC);
        }

        public override string GetName()
        {
            return "Найти произведение двух матриц.";
        }