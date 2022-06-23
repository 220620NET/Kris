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
Console.WriteLine(answer);
int guess = 0;
int tries = 12;
string history = "_";
string current ="_";
string movement ="_";

//Now starting the game with a system that counts down from the max number of tries
while(tries>0 || current != "Correct"){
    Round(tries);
    guess = int.Parse(Console.ReadLine());
    // Need to check if number is near far or correct
    Console.WriteLine(HotCold(guess));
    current = HotCold(guess);
    if (current == "Correct"){
        Console.WriteLine("You won");
    }else{
        movement = Change(history,current);
        Console.WriteLine(movement);
    }    
    history = current;
    tries --;
}

/* HotCold Method
    This method gathers if the user's guess is a particular distance from the number
    
    If the user's guess is 5 away or closer to the number 
*/
string HotCold(int guess){
    int dist = answer-guess;
    if(dist == 0){
        return "Correct";
    }if(dist<5 || dist >-5){
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
string Change(string past, string present){
    int val1 = Position(past);
    int val2 = Position(present);
    if(past == "" || past == present){
        return "No change";
    }else if(val2<val1){
        return "Getting Hotter";
    }else{
        return "Getting Colder";
    }
}

int Position(string k){
    if(k =="Hot"){
        return 1;
    }else if(k == "Warm"){
        return 2;
    }else if(k == "Luke warm"){
        return 3;
    }else if(k == "Cold"){
        return 4;
    }else if (k =="Freezing"){
        return 5;
    }else{
        return 0;
    }
}

void Round(int time){
    Console.WriteLine("What do you think the number is? Hint: it is between 0 and 100 ");
}