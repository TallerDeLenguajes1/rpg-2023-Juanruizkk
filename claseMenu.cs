using static System.Console;
namespace keyboardMenu
{

    class Menu
    {
        private int SelectedIndex;
        private string[] Options;
        private string Prompt;

        public Menu(string prompt, string[] options)
        {
            Prompt = prompt;
            Options = options;
            SelectedIndex = 0;
        }
        public Menu()
        {

        }


        private void DisplayOptions()
        {
            WriteLine(Prompt);
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                string prefix;

                if (i == SelectedIndex)
                {
                    prefix = "*";
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefix = " ";
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                }
                WriteLine($"{prefix}<<{currentOption}>>");
            }
            ResetColor();
        }



        public void runMainMenu()
        {
            string aux = @"
┌┐ ┬  ┌─┐┌─┐┌┬┐  ┬  ┌─┐┌─┐┬┌─
├┴┐│  │ ││ │ ││  │  ├┤ ├─┤├┴┐
└─┘┴─┘└─┘└─┘─┴┘  ┴─┘└─┘┴ ┴┴ ┴
";
            string[] options = { "Jugar", "Salir" };
            Menu mainMenu = new Menu(aux, options);
            int SelectedIndex = mainMenu.Run();

            if (SelectedIndex == 1)
            {
                ExitGame();
            }

        }
        public void ExitGame()
        {
            Environment.Exit(0);
        }
        public int Run()
        {
            ConsoleKey keyPressed;
            do
            {
                Clear();
                DisplayOptions();
                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;
                if (keyPressed == ConsoleKey.UpArrow)
                {
                    SelectedIndex--;
                    if (SelectedIndex == -1)
                    {
                        SelectedIndex = Options.Length - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    SelectedIndex++;
                    if (SelectedIndex == Options.Length)
                    {
                        SelectedIndex = 0;
                    }
                }

            } while (keyPressed != ConsoleKey.Enter);
            return SelectedIndex;
        }
    }

}