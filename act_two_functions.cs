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
                for (int sp = 1; sp <= space; sp++) { // number - r
                    Console.Write("_");
                }

                for (int c = 1; c <= (r * 2) - 1; c++) {
                    Console.Write("*");
                }

                for (int sp = 1; sp <= space; sp++) { // number - r
                    Console.Write("_");
                }

                space--;
                Console.WriteLine();
            }
        }

        public static void drawReversedIsoscelesTriangle(int number) {

        }
    }
}
