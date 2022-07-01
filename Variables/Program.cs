string playerName = "Cloud Strife";
int playerLevel = 99;
char soldierClass = '1';
bool swordSwing = true;
double materiaSlots = 12;
decimal accuracy = 99.9m;

Console.WriteLine($"My character's name is {playerName}. He is Soldier Class {soldierClass}, " +
    $" level {playerLevel}. He has {materiaSlots} materia slots but it's {swordSwing}" +
    $" that he loves to swing his ginormous sword around more than use magic. And he" +
    $" does so with {accuracy}% accuracy.");
