class Dino : Creatures{
    public Dino(){
        intelligence = Random.Shared.Next(5,10);
        endurance = Random.Shared.Next(5,10);
        strength = Random.Shared.Next(5,10);

    }
}