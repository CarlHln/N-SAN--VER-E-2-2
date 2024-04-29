using System.Reflection.Metadata.Ecma335;

class Creatures{
protected int intelligence = 0;
protected int endurance = 0;
protected int strength = 0;

public int Chess(){
    int result = Random.Shared.Next(0,10) + intelligence;

    if(result > 20){
        return 20; 
    }
    else{
        return result;
    }
}

public int ArmWrestling(){
    int result = Random.Shared.Next(0,10) + strength;

    if(result>20){
        return 20;
    }
    else{
        return result;
    }
}

public int Sumo(){
    int result = Random.Shared.Next(0,10) + endurance + strength;

    if(result>20){
        return 20;
    }
    else{
        return result; 
    }
}
}