/*
    Hot Or Cold Game
    10 tries
    
    1. Generate a random number
    2. Ask the user for a number
    3. see if random number if above or below user
        a. use terms hot if near (within 5)
        b. use term warm (within 10)
        c. use term luke warm( within 15)
        d. use term cold  (within 20)
        e. use term freezing (within 25)
    4. add history for distance
        a. hotter if getting closer to
        b. colder if getting farther away
        c. use a hint system if they are getting colder twice in a row.
            i. above or below a certain number (only on the frst hint and if they have guessed in this range)
            ii. even or odd
            ii. if the two numbers that the user has put in recently share a modulo with the answer

*/
int[] leader = new int[5];

Beginning:
//Getting information from background commputer and user

bool play = true;

//Now starting the game with a system that counts down from the max number of tries
while (play){
    Console.Clear();
    Random num = new Random();
    int answer = num.Next(100);
    int tries = 12;
    int history= 0;
    int current =0;
    string movement ="_";
    string cu = "_";
    string p = "";
    if (leader[0] != 0){
        Console.WriteLine("The fastest game lasted "+ leader[0]+" turns. Can you beat that?");
    }
    
    while(tries>0 && cu != "Correct"){
    Round(tries);
    current = int.Parse(Console.ReadLine());
    // Need to check if number is near far or correct
    Console.WriteLine(HotCold(current,answer));
    cu = HotCold(current, answer);
    if (cu == "Correct"){
        Console.WriteLine("You won");

    }else{
        movement = Change(history,current,answer);
        Console.WriteLine(movement);
    }    
    history = current;
    tries --;
    } 
    Console.WriteLine("Would you like to continue playing?");
    p = Console.ReadLine();
    if(p =="y"){
        play = true;
        leader = LeaderBoard(tries);
        goto Beginning;
    }else{
        play = false;
    }
}


/* HotCold Method
    This method gathers if the user's guess is a particular distance from the number
    
    If the user's guess is 5 away or closer to the number we say that the user is Hot
    If the user's guess is 10 away or closer to the number we say that the user is Warm
    If the user's guess is 15 away or closer to the number we say that the user is Luke warm
    If the user's guess is 25 away or closer to the number we say that the user is Cold
    If the user's guess is more than 25 away from the number we say that the user is Freezing

    Only one output of this method is allowed so switch statements would not be acceptable if elseif is better here
*/
string HotCold(int guess, int answer){
    int dist = Math.Abs(answer-guess);
    if(dist == 0){
        return "Correct";
    }if(dist<5){
        return "Hot";
    }else if(dist<10){
        return "Warm";
    }else if(dist<15){
        return "Luke warm";
    }else if(dist<25){
        return "Cold";
    }else{
        return "Freezing";
    }
}

/*  Change Method

    This method prints out if the user has moved closer

    Since some numbers could be negative for distances we send it to a function to find the absolute value of the value
    If the game just started or if the value that the user inputted was the same as what the inputted previously the game says there has been No Change
    If the distance that was just guessed is closer to the answer than what was previously guessed the game says the user is Getting Hotter
    If the distance that was just guessed is farther away from the answer than what was previously guessed the game says the user is Getting Colder

    Again only one output is desired so this will be accomplished by using if elseif statements
*/
string Change(int hist, int current,int answer){
    if(hist ==0 || hist==current){
        return "No change";
    }else if(Math.Abs(answer-current)<Math.Abs(answer-hist)){
        return "Getting Hotter";
    }else{
        return "Getting Colder";
    }
}

/*  Round Method

    This method simply prints a nice question to the player.
*/
void Round(int time){
    Console.WriteLine("What do you think the number is? Hint: it is between 0 and 100 ");
    Console.WriteLine("You have "+ time+ " tries left.");
}

/* Leaderboard Method

    This method saves a leader board of the fastest rounds
*/
int[] LeaderBoard(int tries){
    int [] k = new int[5]{ 0, 0,0,0,0};
    for(int i=0; i<5;i++){
        if(k[i]==0){
            k[i] = tries;
        }else if(k[i]>tries){
            k[i] =tries;
        }
    }
    return k;
}