namespace Zadacha
{
   
   
        public abstract class Piece
        {
            public int X { get; set; }
            public int Y { get; set; }

            public abstract bool CanBeat(Piece other);
        }

        public class King : Piece
        {
            public override bool CanBeat(Piece other)
            {
                // Логика проверки бития королем
                return false;
            }
        }

        public class Queen : Piece
        {
            public override bool CanBeat(Piece other)
            {
                // Логика проверки бития ферзем
                return false;
            }
        }

        public class Rook : Piece
        {
            public override bool CanBeat(Piece other)
            {
                // Логика проверки бития ладьей
                return false;
            }
        }

        public class Bishop : Piece
        {
            public override bool CanBeat(Piece other)
            {
                // Логика проверки бития слоном
                return false;
            }
        }

        public class Knight : Piece
        {
            public override bool CanBeat(Piece other)
            {
                // Логика проверки бития конем
                return false;
            }
        }

        public class Shadow : Piece
        {
            public override bool CanBeat(Piece other)
            {
                // Логика проверки бития теником
                return false;
            }
        }

        public class Program
        {
            public static void Main()
            {
                // Создание объектов фигур
                King king = new King();
                Queen queen = new Queen();
                Rook rook = new Rook();
                Bishop bishop = new Bishop();
                Knight knight = new Knight();
                Shadow shadow = new Shadow();

                // Установка координат для каждой фигуры
                king.X = 0;
                king.Y = 0;

                queen.X = 5;
                queen.Y = 1;

                rook.X = 1;
                rook.Y = 3;

                bishop.X = 3;
                bishop.Y = 7;

                knight.X = 5;
                knight.Y = 5;


            // Проверка битья фигур (король)
            if (king.CanBeat(queen))
                {
                    Console.WriteLine("Король бьет ферзя");
                }
                else
                {
                    Console.WriteLine("Король не бьет ферзя");
                }
          
            if (king.CanBeat(rook))
                {
                    Console.WriteLine("Король бьет ладью");
                }
                else
                {
                    Console.WriteLine("Король не бьет ладью");
                }
           
            if (king.CanBeat(bishop))
            {
                Console.WriteLine("Король бьет слона");
            }
            else
            {
                Console.WriteLine("Король не бьет слона");
            }

            if (king.CanBeat(knight))
            {
                Console.WriteLine("Король бьет коня");
            }
            else
            {
                Console.WriteLine("Король не бьет коня");
            }




            // Проверка битья фигур (ферзь)
            if (queen.CanBeat(king))
            {
                Console.WriteLine(" Ферзь  бьет король");
            }
            else
            {
                Console.WriteLine("Ферзь  не бьет король");
            }

            if (queen.CanBeat(rook))
            {
                Console.WriteLine("Ферзь бьет ладью");
            }
            else
            {
                Console.WriteLine("Ферзь не бьет ладью");
            }

            if (queen.CanBeat(bishop))
            {
                Console.WriteLine("Ферзь бьет слона");
            }
            else
            {
                Console.WriteLine("Ферзь не бьет слона");
            }

            if (queen.CanBeat(knight))
            {
                Console.WriteLine("Ферзь бьет коня");
            }
            else
            {
                Console.WriteLine("Ферзь не бьет коня");
            }



            // Проверка битья фигур (ладья)
            if (rook.CanBeat(king))
            {
                Console.WriteLine("Ладья  бьет короля");
            }
            else
            {
                Console.WriteLine("Ладья  не бьет короля");
            }

            if (rook.CanBeat(queen))
            {
                Console.WriteLine("Ладья  бьет ферзя");
            }
            else
            {
                Console.WriteLine("Ладья  не бьет ферзя");
            }

            if (rook.CanBeat(bishop))
            {
                Console.WriteLine("Ладья бьет слона");
            }
            else
            {
                Console.WriteLine("Ладья не бьет слона");
            }

            if (rook.CanBeat(knight))
            {
                Console.WriteLine("Ладья бьет коня");
            }
            else
            {
                Console.WriteLine("Ладья не бьет коня");
            }



            // Проверка битья фигур (слон)
            if (bishop.CanBeat(queen))
            {
                Console.WriteLine("Слон бьет ферзя");
            }
            else
            {
                Console.WriteLine("Слон не бьет ферзя");
            }

            if (bishop.CanBeat(rook))
            {
                Console.WriteLine("Слон бьет ладью");
            }
            else
            {
                Console.WriteLine("Слон не бьет ладью");
            }

            if (bishop.CanBeat(king))
            {
                Console.WriteLine("Слон бьет короля");
            }
            else
            {
                Console.WriteLine("Слон не бьет короля");
            }

            if (bishop.CanBeat(knight))
            {
                Console.WriteLine("Слон бьет коня");
            }
            else
            {
                Console.WriteLine("Слон не бьет коня");
            }


            // Проверка битья фигур (конь)
            if (knight.CanBeat(queen))
            {
                Console.WriteLine("Конь бьет ферзя");
            }
            else
            {
                Console.WriteLine("Конь не бьет ферзя");
            }

            if (knight.CanBeat(rook))
            {
                Console.WriteLine("Конь бьет ладью");
            }
            else
            {
                Console.WriteLine("Конь не бьет ладью");
            }

            if (knight.CanBeat(bishop))
            {
                Console.WriteLine("Конь бьет слона");
            }
            else
            {
                Console.WriteLine("Конь не бьет слона");
            }

            if (knight.CanBeat(king))
            {
                Console.WriteLine("Конь бьет короля");
            }
            else
            {
                Console.WriteLine("Конь не бьет короля");
            }




            // Вывод псевдографики с расположением фигур
            Console.WriteLine("Псевдографика:");
                Console.WriteLine("Король: (0, 0)");
                Console.WriteLine("Ферзь: (5, 1)");
                Console.WriteLine("Ладья: (1, 3)");
                Console.WriteLine("Слон: (3, 7)");
                Console.WriteLine("Конь: (5, 5)");
                


        }
        }
}
