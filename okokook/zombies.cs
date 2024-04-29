class Zombie : Creatures{
    public Zombie(){
        intelligence = Random.Shared.Next(2,10);
        endurance = Random.Shared.Next(10,18);
        strength = Random.Shared.Next(5,10);

        
    }
}