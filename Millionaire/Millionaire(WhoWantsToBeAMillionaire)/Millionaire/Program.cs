using ClassLb;
using System;

namespace Millionaire
{
    class Program
    {
        static void Main(string[] args)  
        {
            Console.WriteLine("============ Who Wants To Be Milionaire ============");
            Console.WriteLine("====================== WELCOME =====================");

            try
            {
                while (true)
                {
                    Console.WriteLine("Press Enter \n1 to start the game, or \n2 to cancel:");
                    string optionChoice = Console.ReadLine();

                    if (optionChoice == "1")
                    {

                    }

                }

            }
            catch (Exception)
            {

                throw;
            }


        }

            
            #region Questions

            Question question01 = new Question()
            {
                Text = "In the UK, the abbreviation NHS stands for National what Service?",
                PossibleAnswer = new string[] { "Humanity", "Health", "Honour", "Household" },
                correctAnswer = 2,
                SelectedAnswer = 0

            };

            Question question02 = new Question()
            {
                Text = "Which Disney character famously leaves a glass slipper behind at a royal ball?",
                PossibleAnswer = new string[] { "Pocahontas", "Sleeping Beauty", "Cinderella", "Elsa" },
                correctAnswer = 3,
                SelectedAnswer = 0

            };

            Question question03 = new Question()
            {
                Text = "What name is given to the revolving belt machinery in an airport that delivers checked luggage from the plane to baggage reclaim?",
                PossibleAnswer = new string[] { "Hangar", "Terminal", "Concourse", "Carousel" },
                correctAnswer = 4,
                SelectedAnswer = 0

            };

            Question question04 = new Question()
            {
                Text = "Which of these brands was chiefly associated with the manufacture of household locks?",
                PossibleAnswer = new string[] { "Phillips", "Flymo", "Chubb", "Ronseal" },
                correctAnswer = 3,
                SelectedAnswer = 0

            };

            Question question05 = new Question()
            {
                Text = "The hammer and sickle is one of the most recognisable symbols of which political ideology?",
                PossibleAnswer = new string[] { "Republicanism", "Communism", "Conservatism", "Liberalism" },
                correctAnswer = 2,
                SelectedAnswer = 0

            };

            Question question06 = new Question()
            {
                Text = "Which toys have been marketed with the phrase “robots in disguise”?",
                PossibleAnswer = new string[] { "Bratz Dolls", "Sylvanian Families", "Hatchimals", "Transformers" },
                correctAnswer = 4,
                SelectedAnswer = 0

            };

            Question question07 = new Question()
            {
                Text = "What does the word loquacious mean?",
                PossibleAnswer = new string[] { "Angry", "Chatty", "Beautiful", "Shy" },
                correctAnswer = 2,
                SelectedAnswer = 0

            };

            Question question08 = new Question()
            {
                Text = "Obstetrics is a branch of medicine particularly concerned with what?",
                PossibleAnswer = new string[] { "Childbirth", "Broken bones", "Heart conditions", "Old age" },
                correctAnswer = 1,
                SelectedAnswer = 0

            };

            Question question09 = new Question()
            {
                Text = "In Doctor Who, what was the signature look of the fourth Doctor, as portrayed by Tom Baker?",
                PossibleAnswer = new string[] { "Bow-tie, braces and tweed jacket", "Wide-brimmed hat and extra long scarf", "Pinstripe suit and trainers", "Cape, velvet jacket and frilly shirt" },
                correctAnswer = 2,
                SelectedAnswer = 0

            };

            Question question10 = new Question()
            {

                Text = "Which of these religious observances lasts for the shortest period of time during the calendar year?",
                PossibleAnswer = new string[] { "Ramadan", "Diwali", "Lent", "Hanukkah" },
                correctAnswer = 2,
                SelectedAnswer = 0

            };

            Question question11 = new Question()
            {
                Text = "At the closest point, which island group is only 50 miles south-east of the coast of Florida?",
                PossibleAnswer = new string[] { "Bahamas", "US Virgin Islands", "Turks and Caicos Islands", "Bermuda" },
                correctAnswer = 1,
                SelectedAnswer = 0

            };

            Question question12 = new Question()
            {
                Text = " Construction of which of these famous landmarks was completed first?",
                PossibleAnswer = new string[] { "Empire State Building", "Royal Albert Hall", "Eiffel Tower", "Big Ben Clock Tower" },
                correctAnswer = 4,
                SelectedAnswer = 0

            };

            Question question13 = new Question()
            {
                Text = "Which of these cetaceans is classified as a “toothed whale”?",
                PossibleAnswer = new string[] { "Gray whale", "Minke whale", "Sperm whale", "Humpback whale" },
                correctAnswer = 3,
                SelectedAnswer = 0

            };

            Question question14 = new Question()
            {
                Text = "Who is the only British politician to have held all four “Great Offices of State” at some point during their career?",
                PossibleAnswer = new string[] { "David Lloyd George", "Harold Wilson", "James Callaghan", "Humpback whale" },
                correctAnswer = 3,
                SelectedAnswer = 0

            };

            Question question15 = new Question()
            {
                Text = "In 1718, which pirate died in battle off the coast of what is now North Carolina?",
                PossibleAnswer = new string[] { "Calico Jack", "Blackbeard", "Bartholomew Roberts", "Captain Kidd" },
                correctAnswer = 2,
                SelectedAnswer = 0

            };
            #endregion

          
        
    }
}
