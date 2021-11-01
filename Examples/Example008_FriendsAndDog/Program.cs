double distance = 10000;
double firstFriendSpeed = 2;
double secondFriendSpeed = 4;
double dogSpeed = 6;
double time = 0;
int friend = 2;

double count = 0;

while(distance > 2)
{
        if(friend == 1)
    {
        time = distance/(firstFriendSpeed+dogSpeed);
        friend = 2;
    }
    else
    {
        time = distance/(secondFriendSpeed+dogSpeed);
        friend = 1;
    }
    distance = distance - (firstFriendSpeed + secondFriendSpeed)*time;
    count++;
}

Console.Write("Собака пробежит ");
Console.Write(count);
Console.Write(" раз между друзьями");