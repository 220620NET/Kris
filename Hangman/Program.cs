/*
    This is a hangman game by Kristopher Holland 
    Hangman is a game where a user must guess a randomly picked word in a limited amount of tries

    6 Tries

    The user guesses a leter, then we can tell if it exists in the word or not
    If the letter exists in the word then we fill the letter in
*/

/*
    Maybe I should give users option to 1 Guess a letter 2. Guess the word
    and then depending on the result, I'll let them know accordingly
*/

/*
    I want a word bank or a way to randomly choose a word
*/

// Array is a data structure that holds multiple data of the same type. They are fixed length at initializationand when we run out of space, we create a new bigger array.
string[] wordBank = new string [10]{"apple", "banana", "orange", "lime", "lemon", "grapefruit", "grape", "tangerine", "watermelon", "cabbage"};
bool play = true;

Begining:
while(play){
    Random num = new Random();
    int t = 6;
    int i = num.Next(10); //Will be a random number
    int sizeOfWord = wordBank[i].Length; // size of word
    string answer = wordBank[i];
    string choice = "";
    char[] display = new char[sizeOfWord];
    int annoyance = 0;
    while(t>0){
        
        choice = Round(display,t);
        if (choice == "1"){
            Console.WriteLine("What Letter do you want to guess?");
            string letter = Console.ReadLine();
            char guess = letter[0];
            bool check = CheckWord(guess,answer,display);
            if(check){
                Console.WriteLine(DisplayGuess(display));
                if(IsComplete(display)){
                    Console.WriteLine("You won!");
                    break;
                }
            }
            else{
                Console.WriteLine("The word does not contain this letter. Try again.");
            }
            t--;
        }else if(choice == "2"){
            Console.WriteLine("What is the word?");
            string final = Console.ReadLine();
            if(final == answer){
                Console.WriteLine("You won!");
                break;
            }else{
                Console.WriteLine("Sorry that is wrong. Try again. Maybe try a letter. :( ");
                t --;
            }        
        }else{
            annoyance++;
            if(annoyance>4){
                Console.WriteLine("I warned you now you have "+ t--+" tries.");
            }else{
                switch(annoyance){
                    case 1:
                        // code block
                        Console.WriteLine("I implore you to either type 1 or 2 and not be adventurous");
                        break;
                    case 2:
                        // code block
                        Console.WriteLine("Ok... haha... funny... now please enter a 1 or 2.");
                        break;
                    case 3:
                        Console.WriteLine("Last warning before you start losing tries. Type 1 or 2!");
                        break;
                    case 4:
                        Console.WriteLine("Last warning before you start losing tries. Type 1 or 2!");
                        break;
                    default:
                        break;
                }        
            }
        }    
        if (t == 0){
            Console.WriteLine("You ran out of tries.");
            if(annoyance>=3){
                Console.WriteLine("Maybe next time follow instructions. I mean this in the nicest way.");
            }
            
        }
    }
    Console.WriteLine("Do you want to try again?[Enter 'y' for yes or 'n' for no]");
    string p = Console.ReadLine();
    if (p=="n"){
        play = false;
        Console.WriteLine("I am sad to see you go. Come again soon.");
    }else{
        Console.Clear();
        goto Begining;
    }
}
string DisplayGuess(char[] temp){
    string display = "";
    for(int i=0; i<temp.Length;i++){
        if(Char.IsLetter(temp[i])){
            display+= temp[i]+" ";
        }
        else{
            display += "_ ";
        }
    }
    return display;
}

bool CheckWord(char guess, string answer, char[] display){
    for (int i = 0; i< answer.Length; i++){
        if(answer[i] == guess){
            display[i] = guess;
            return true;
        }
    }
    return false;
}
bool IsComplete(char[] guess){
    for(int i=0; i<guess.Length;i++){
        if(!Char.IsLetter(guess[i])){
            return false;
        }
    }
    return true;
}

/* round Method

    This method begins the game by informing the player several things
    If the player just started the game then the game will inform the player how many
*/
string Round(char[] display, int tries){
    if (tries ==6){
        Console.WriteLine("Welcome to Hangman. Please follow the instructions to play along and try to guess the word.");
        Console.WriteLine( "Your word has "+display.Length + " letters. Good Luck you have six guesses!");
    }    
    Console.WriteLine(tries+" Tries Remaining");
    Console.WriteLine(DisplayGuess(display));
    Console.WriteLine("What would you like to guess? [Enter 1 for a letter 2 for a word]");
    return Console.ReadLine();
}