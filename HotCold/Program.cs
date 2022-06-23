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

//Getting information from background commputer and user
Random num = new Random();
int answer = num.Next(100);
Console.WriteLine("What do you think the number is? Hint: it is between 0 and 100 ");
int guess = int.Parse(Console.ReadLine());
int tries = 12;
//Now starting the game with a system that counts down from the max number of tries
while(tries>0){
    // Need to check if number is near far or correct
    Console.WriteLine(HotCold(guess));
    tries --;
}

string HotCold(int guess){
    int dist = answer-guess;
    if(dist<5 || dist >-5){
        return "Hot";
    }else if(dist <10 || dist >-10){
        return "Warm";
    }else if(dist <15||dist>-15){
        return "Luke warm";
    }else if(dist<20||dist>-20){
        return "Cold";
    }else{
        return "Freezing";
    }
}