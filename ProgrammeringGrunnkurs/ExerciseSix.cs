using System;

namespace ProgrammeringGrunnkurs
{
    class ExerciseSix
    {
        public void TaskOne(int loopCounter)
        {
            int[] res = new int[10];

            var random = new Random();

            for (int i = 0; i <= loopCounter; i++)
            {
                switch (random.Next(0, 10))
                {
                    case 0:
                        res[0] += 1;
                        break;
                    case 1:
                        res[1] += 1;
                        break;
                    case 2:
                        res[2] += 1;
                        break;
                    case 3:
                        res[3] += 1;
                        break;
                    case 4:
                        res[4] += 1;
                        break;
                    case 5:
                        res[5] += 1;
                        break;
                    case 6:
                        res[6] += 1;
                        break;
                    case 7:
                        res[7] += 1;
                        break;
                    case 8:
                        res[8] += 1;
                        break;
                    case 9:
                        res[9] += 1;
                        break;
                }
            }

            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine($"{i} : {res[i]}");
            }
        }
        //Task two
        private class TextAnalysis
        {
            public TextAnalysis(string text)
            {
                char[] textArr = text.ToLower().ToCharArray();

                for (int i = 0; i < textArr.Length; i++)
                {
                    int deciValue = Convert.ToInt32(textArr[i]) - 97;
                    if (deciValue >= 0 && deciValue <= 26)
                    {
                        CharactersInText[deciValue] += 1;
                    }
                    else
                    {
                        CharactersInText[26]++;
                    }
                }
            }

            private int[] CharactersInText { get; } = new int[27];

            public void PrintArr()
            {
                for (int i = 0; i < CharactersInText.Length; i++)
                {
                    Console.WriteLine("{0} : {1}", Convert.ToChar(i + 97),  CharactersInText[i]);
                }
            }

            public void NumberOfDiffCharacters()
            {
                int diffChars = 0;

                for (int i = 0; i < CharactersInText.Length-1; i++)
                {
                    if (CharactersInText[i] != 0)
                    {
                        diffChars++;
                    }
                }

                Console.WriteLine("Number of different characters in text: {0}", diffChars);
            }

            public void TotalNumberOfCharacters()
            {
                int totalNumberOFChars = 0;

                for (int i = 0; i < CharactersInText.Length-1; i++)
                {
                    if (CharactersInText[i] != 0)
                    {
                        totalNumberOFChars += CharactersInText[i];
                    }
                }

                Console.WriteLine("Total number of characters in text: {0}", totalNumberOFChars);
            }

            public void PercentNonCharacters()
            {
                int totalNumberOFChars = 0;
                int nonCharacters = CharactersInText[26];

                for (int i = 0; i < CharactersInText.Length - 1; i++)
                {
                    if (CharactersInText[i] != 0)
                    {
                        totalNumberOFChars += CharactersInText[i];
                    }
                }

                double percent = (nonCharacters * 100) / (totalNumberOFChars + nonCharacters);
                Console.WriteLine("Percent of non characters in text: {0}", percent);
            }

            public void NumberOfSpecificCharacter(char test)
            {
                Console.WriteLine("The text contains {0} {1} times", test, CharactersInText[Convert.ToInt32(test)-97]);
            }

            public void MostCommonCharacters()
            {

            }
        }

        public void RunTasks()
        {
            //TaskOne(1000);
            TextAnalysis tasktwo = new TextAnalysis("hello, world!");
            tasktwo.NumberOfDiffCharacters();
            tasktwo.TotalNumberOfCharacters();
            tasktwo.PercentNonCharacters();
            tasktwo.NumberOfSpecificCharacter('l');

        }
    }
}
