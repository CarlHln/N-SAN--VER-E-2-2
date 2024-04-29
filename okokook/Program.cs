using System.Globalization;

List<Dino> dinos = new List<Dino>();
List<Zombie> zombies = new List<Zombie>();

bool success = false;
int number;
while(success == false){
    Console.WriteLine("Please write in the amount of players in each team");
    string inputNumber = Console.ReadLine();


if(int.TryParse(inputNumber, out number) && number > 0){
    success = true;
}
else{
    System.Console.WriteLine("Invalid");
}
}

for(int i = 0; i < number ; i++){
    Dino dino = new Dino();
    Zombie zombie = new Zombie();
    dinos.Add(dino);
    zombies.Add(zombie);
}



Console.ReadLine();



