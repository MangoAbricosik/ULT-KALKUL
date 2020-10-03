using System;

namespace Ult_Ult_kalkul
{
    class Program
    {
        // i = stolb k = stroka


        /*
         * 11 12 13
         * 21 22 23
         * 31 32 33
         * 
         * 
         * for (stolb = 0;stolb <= nonull; stolb += 1)
            {
                for (stroka = 0; stroka <= nonull; stroka += 1)
                {
                    int sumGL = matric[stolb, stroka];

                }
            }
         * 
         * 
         * do
            {
                if (stolb == 0)
                {
                    continue;
                }
                else
                {
                    stolb += 1;
                }
                do
                {
                    if (stroka== 0)
                    {
                        continue;
                    }
                    else
                    {
                        stroka += 1;
                    }
                    dioPLUS += matric[stolb, stroka];
                }
                while (stroka <= nonull);
            }
            while (stolb <= nonull);
         * 
        */
        static public int matSUM()
        {
            int stroka1;
            int stolb1;
            Console.WriteLine("Столбцы, Строки");
            int stolb = Convert.ToInt32(Console.ReadLine());
            int stroka = Convert.ToInt32(Console.ReadLine());
            int strokaSAVE = stroka - 1; int stolbSAVE = stroka - 1; 
            int[,] matric = new int[stolb+stolb-1, stroka+stroka-1];
            for (stolb1 = 0; stolb1 < stolb; stolb1 += 1)
            {
                for (stroka1 = 0; stroka1 < stroka; stroka1 += 1)
                {
                    matric[stolb1, stroka1] = Convert.ToInt32(Console.ReadLine());
                }
            }

           for (stolb1 = 1; stolb1<stolb; stolb1 += 1)
            {
                for (stroka1 = 1; stroka1 < stroka; stroka1 += 1)
                {
                    matric[stolb + 1, stroka + 1] = matric[stolb1, stroka1];
                }
            }


            int nonull;

            if (stolb > stroka)
            {
                nonull = stroka;
            }
            else
            {
                nonull = stolb;
            }

            int dioPLUS = 0;

            

            int dioCHET;
            int dioCHET1;




            
              for (dioCHET1 = 0; dioCHET1<nonull; dioCHET1 += 1)
            {
                for (dioCHET = dioCHET1; dioCHET < nonull; dioCHET += 1)
                {
                    for (stolb1 = dioCHET+dioCHET1; stolb1 < nonull; stolb1 += 1)
                    {
                        for (stroka1 = dioCHET; stroka1 < nonull; stroka1 += 1)
                        {
                            dioPLUS += matric[stolb1, stroka1];
                            break;
                        }
                        break;
                    }
                    
                }
            }
            



            return dioPLUS;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("матрица - 1");
            int chto = Convert.ToInt32(Console.ReadLine());

            switch (chto)
            {
                case 1:
                    Console.WriteLine(matSUM());
                    break;
            }
        }
    }
}
