using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        enum Options { 
            Yellow = 1,
            Purple = 2,
            Pink = 3,
            Blue = 4,
            White = 5,
            Exit = 6
        };

        static bool exit = false;

        /// <summary>
        /// Default value to display to menu
        /// </summary>
        static Options option = Options.Yellow;

        static void Main()
        {
            DefaultSelected();

            while (!exit)
            {
                ConsoleKeyInfo keyData = Console.ReadKey();

                if (keyData.Key is ConsoleKey.Enter)
                {
                    Result();   // AQUI DESARROLLO EL IF DE LA NOTA
                }
                else
                {
                    PrintMenu(keyData);
                }
            }

            Console.Clear();
        }

        static void GetOption(ConsoleKeyInfo keyData)
        {
            if (keyData.Key is ConsoleKey.UpArrow)
            {
                if (option is Options.Yellow)
                {
                    option = Options.Exit;
                }
                else
                {
                    option--;
                }
            }

            if (keyData.Key is ConsoleKey.DownArrow)
            {
                if (option is Options.Exit)
                {
                    option = Options.Yellow;
                }
                else
                {
                    option++;
                }
            }
        }

        static void Result()
        {
            if (option is Options.Exit)
            {
                exit = true;
                return;
            }

            if (option is Options.Yellow)
            {
                PrintResult(2);
            }

            if (option is Options.Purple)
            {
                PrintResult(7);
            }

            if (option is Options.Pink)
            {
                PrintResult(9);
            }

            if (option is Options.Blue)
            {
                PrintResult(6);
            }

            if (option is Options.White)
            {
                PrintResult(12);
            }

            DefaultSelected();
        }

        static void PrintResult(int multiple)
        {
            Console.Clear();

            Console.WriteLine($"\t\tTABLA DEL {multiple}\n\n");

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"\t{multiple}x{i}={multiple * i}");
            }

            Console.WriteLine("\n\n\n\nOPRIMA ENTER PARA CONTINUAR");

            Console.ReadKey(false);

        }

        #region MENÚ

        static void PrintMenu(ConsoleKeyInfo? keyData)
        {
            //string menu = string.Empty;

            Console.Clear();

            if (keyData is not null) GetOption(keyData.Value);

            switch (option)
            {
                case Options.Yellow:
                    YellowSelected();
                    break;

                case Options.Purple:
                    PurpleSelected();
                    break;

                case Options.Pink:
                    PinkSelected();
                    break;

                case Options.Blue:
                    BlueSelected();
                    break;

                case Options.White:
                    WhiteSelected();
                    break;

                default:
                    ExitSelected();
                    break;
            }
        }

        static void DefaultSelected()
        {
            PrintMenu(null);
        }

        static void YellowSelected()
        {
            string menu =
                "\t\t\tMENÚ\n\n\n" +
                "\t--->AMARILLO<---\n" +
                "\tMORADO\n" +
                "\tROSA\n" +
                "\tAZUL\n" +
                "\tBLANCO\n\n" +
                "\tSALIR" +
                "\n\n\n\nUSE LAS FLECHAS ARRIBA Y ABAJO DEL TECLADO Y ENTER PARA SELECCIONAR";

            Console.WriteLine(menu);
        }

        static void PurpleSelected()
        {
            string menu =
                "\t\t\tMENÚ\n\n\n" +
                "\tAMARILLO\n" +
                "\t--->MORADO<---\n" +
                "\tROSA\n" +
                "\tAZUL\n" +
                "\tBLANCO\n\n" +
                "\tSALIR" +
                "\n\n\n\nUSE LAS FLECHAS ARRIBA Y ABAJO DEL TECLADO Y ENTER PARA SELECCIONAR";

            Console.WriteLine(menu);
        }

        static void PinkSelected()
        {
            string menu =
                "\t\t\tMENÚ\n\n\n" +
                "\tAMARILLO\n" +
                "\tMORADO\n" +
                "\t--->ROSA<---\n" +
                "\tAZUL\n" +
                "\tBLANCO\n\n" +
                "\tSALIR" +
                "\n\n\n\nUSE LAS FLECHAS ARRIBA Y ABAJO DEL TECLADO Y ENTER PARA SELECCIONAR";

            Console.WriteLine(menu);
        }

        static void BlueSelected()
        {
            string menu =
                "\t\t\tMENÚ\n\n\n" +
                "\tAMARILLO\n" +
                "\tMORADO\n" +
                "\tROSA\n" +
                "\t--->AZUL<---\n" +
                "\tBLANCO\n\n" +
                "\tSALIR" +
                "\n\n\n\nUSE LAS FLECHAS ARRIBA Y ABAJO DEL TECLADO Y ENTER PARA SELECCIONAR";

            Console.WriteLine(menu);
        }

        static void WhiteSelected()
        {
            string menu =
                "\t\t\tMENÚ\n\n\n" +
                "\tAMARILLO\n" +
                "\tMORADO\n" +
                "\tROSA\n" +
                "\tAZUL\n" +
                "\t--->BLANCO<---\n\n" +
                "\tSALIR" +
                "\n\n\n\nUSE LAS FLECHAS ARRIBA Y ABAJO DEL TECLADO Y ENTER PARA SELECCIONAR";

            Console.WriteLine(menu);
        }

        static void ExitSelected()
        {
            string menu =
                "\t\t\tMENÚ\n\n\n" +
                "\tAMARILLO\n" +
                "\tMORADO\n" +
                "\tROSA\n" +
                "\tAZUL\n" +
                "\tBLANCO\n\n" +
                "\t--->SALIR<---" +
                "\n\n\n\nUSE LAS FLECHAS ARRIBA Y ABAJO DEL TECLADO Y ENTER PARA SELECCIONAR";

            Console.WriteLine(menu);
        }

        #endregion MENÚ
    }
}