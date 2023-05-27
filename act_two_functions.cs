namespace ADET_activities {
    public class act_two_functions {
        public static void drawParallelogram(int number) {
            for(int row = 0; row < number; row++) {
                for(int bef = 0; bef < number - row - 1; bef++) {
                    Console.Write("_");
                }
                
                for(int ast = 0; ast < number; ast++) {
                    Console.Write("*");
                }

                for(int aft = 0; aft < row; aft++) {
                    Console.Write("_");
                }

                Console.WriteLine();
            }
        }

        public static void drawTriangle(int number) {
            for (int i = 0; i < number; i++) {
                for (int j = 1; j <= number - i; j++) {
                    Console.Write("*");
                }

                for (int j = 1; j <= i; j++) {
                    Console.Write("_");
                }

                Console.WriteLine();
            }
        }

        public static void drawReverseTriangle(int number) {
            for (int i = 1; i <= number; i++) {
                for (int j = 1; j <= i; j++) {
                    Console.Write("*");
                }

                for (int j = 1; j <= number - i; j++) {
                    Console.Write("_");
                }

                Console.WriteLine();
            }
        }

        public static void drawIsoscelesTriangle(int number) {
            int space = number / 2;

            for (int r = 1; r <= (number / 2) + 1; r++) {
                for (int sp = 1; sp <= space; sp++) { 
                    Console.Write("_");
                }

                for (int c = 1; c <= (r * 2) - 1; c++) {
                    Console.Write("*");
                }

                for (int sp = 1; sp <= space; sp++) { 
                    Console.Write("_");
                }

                space--;
                Console.WriteLine();
            }
        }

        public static void drawReversedIsoscelesTriangle(int number) {
            int space = 0;

            for(int r = (number / 2) + 1; r >= 1; r--) {
                for(int sp = 1; sp <= space; sp++) { // number - r
                    Console.Write("_");
                }

                for(int c = 1; c <= (r * 2) - 1; c++) {
                    Console.Write("*");
                }

                for(int sp = 1; sp <= space; sp++) { // number - r
                    Console.Write("_");
                }

                space++;
                Console.WriteLine();
            }
        }

        public static void drawHourglass(int number) {
            
            // Upper half of hourglass
            int space = 0;
            for(int r = (number / 2) + 1;r >= 1;r--) {
                for(int sp = 1;sp <= space;sp++) { // number - r
                    Console.Write("_");
                }

                for(int c = 1;c <= (r * 2) - 1;c++) {
                    Console.Write("*");
                }

                for(int sp = 1;sp <= space;sp++) { // number - r
                    Console.Write("_");
                }

                space++;
                Console.WriteLine();
            }

            // lower half of hourglass
            space = number / 2 - 1;
            for(int r = 2; r <= (number / 2) + 1; r++) {
                for(int sp = 1; sp <= space; sp++) { // number - r
                    Console.Write("_");
                }

                for(int c = 1; c <= (r * 2) - 1; c++) {
                    Console.Write("*");
                }

                for(int sp = 1; sp <= space; sp++) { // number - r
                    Console.Write("_");
                }

                space--;
                Console.WriteLine();
            }
        }

        public static void drawDiamond(int number) {
            
            // upper half of diamond
            int space = number / 2;
            for(int r = 1; r <= (number / 2) + 1; r++) {
                for(int sp = 1; sp <= space; sp++) {
                    Console.Write("_");
                }

                for(int c = 1; c <= (r * 2) - 1; c++) {
                    Console.Write("*");
                }

                for(int sp = 1; sp <= space; sp++) {
                    Console.Write("_");
                }

                space--;
                Console.WriteLine();
            }

            // lower half of diamond
            space = 1;
            for(int r = (number / 2); r >= 1; r--) {
                for(int sp = 1; sp <= space; sp++) {
                    Console.Write("_");
                }

                for(int c = 1; c <= (r * 2) - 1; c++) {
                    Console.Write("*");
                }

                for(int sp = 1; sp <= space; sp++) {
                    Console.Write("_");
                }

                space++;
                Console.WriteLine();
            }
        }

        public static void drawZero(int number) {
            for(int i = 1; i <= number; i++) {
                
                if(i == 1 || i == number) {
                    for(int j = 1; j <= number; j++) {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                    continue;
                }

                Console.Write("*");
                    
                for(int s = 1; s <= number - 2; s++) {
                    Console.Write("_");
                }

                Console.Write("*");

                Console.WriteLine();
            }
        }

        public static void drawArrowUp(int number) {
            int space = number / 2;
            int baseWidth = number / 2;
 
            for(int r = 1; r <= (number / 2) + 1; r++) {
                for(int sp = 1; sp <= space; sp++) {
                    Console.Write("_");
                }

                for(int c = 1; c <= (r * 2) - 1; c++) {
                    Console.Write("*");
                }

                for(int sp = 1; sp <= space; sp++) {
                    Console.Write("_");
                }

                space--;
                Console.WriteLine();
            }

            for(int printBase = 1; printBase <= baseWidth; printBase++) {
                for(int baseSpace = 1; baseSpace <= baseWidth - 1; baseSpace++) {
                    Console.Write("_");
                }

                for(int baseAsterisk = 1; baseAsterisk <= 3; baseAsterisk++) {
                    Console.Write("*");
                }

                for(int baseSpace = 1; baseSpace <= baseWidth - 1; baseSpace++) {
                    Console.Write("_");
                }

                Console.WriteLine();
            }
        }

        public static void drawX(int number) {
            for(int row = 1; row <= number; row++) {
                for(int col = 1; col <= number; col++) {
                    if(row == col || col == (number - row + 1))
                        Console.Write("*");
                    else
                        Console.Write("_");
                }
                Console.WriteLine();
            }
        }

        public static void drawBowTie(int number) {
            for(int i = -number/2; i <= number/2; i++) {
                for(int j = -number/2; j <= number/2; j++) {
                    if(i * i <= j * j)
                        Console.Write("*");
                    else
                        Console.Write("_");
                }
                Console.WriteLine();
            }
        }
    }
}
