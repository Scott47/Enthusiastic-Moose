using System;

userQuestion();
// Main();



void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();
    MooseSays("H I, I'M  E N T H U S I A S T I C !");
    MooseSays("I really am enthusiastic");
    CanadaQuestion();
    EnthusiasticQuestion();
    LoveCSharpQuestion();
    SecretQuestion();
}
void userQuestion()
{
    Console.Write($"Ask me a question.");
    Console.ReadLine();
    Random ans = new Random();
    int ramdomAnswer = ans.Next(0, 20);

    switch (ramdomAnswer)
    {
        case 0:
            Console.WriteLine("As I see it, yes.");
            break;
        case 1:
            Console.WriteLine("Ask again later.");
            break;
        case 2:
            Console.WriteLine("Better not tell you now");
            break;
        case 3:
            Console.WriteLine("Cannot predict now");
            break;
        case 4:
            Console.WriteLine("Concentrate and ask again");
            break;
        case 5:
            Console.WriteLine("Don’t count on it.");
            break;
        case 6:
            Console.WriteLine("It is certain.");
            break;
        case 7:
            Console.WriteLine("It is decidedly so.");
            break;
        case 8:
            Console.WriteLine("Most likely.");
            break;
        case 9:
            Console.WriteLine("My reply is no.");
            break;
        case 10:
            Console.WriteLine("My sources say no.");
            break;
        case 11:
            Console.WriteLine("Outlook not so good.");
            break;
        case 12:
            Console.WriteLine("Outlook good.");
            break;
        case 13:
            Console.WriteLine("Reply hazy, try again.");
            break;
        case 14:
            Console.WriteLine("Signs point to yes.");
            break;
        case 15:
            Console.WriteLine("Very doubtful.");
            break;
        case 16:
            Console.WriteLine("Without a doubt.");
            break;
        case 17:
            Console.WriteLine("Yes.");
            break;
        case 18:
            Console.WriteLine("Yes – definitely.");
            break;
        case 19:
            Console.WriteLine("You may rely on it");
            break;
        default:
            Console.WriteLine("say what?");
            break;
    }
}

void CanadaQuestion()
{
    bool isTrue = MooseAsks("Is Canada real?");
    if (isTrue)
    {
        MooseSays("Really? It seems very unlikely.");
    }
    else
    {
        MooseSays("I  K N E W  I T !!!");
    }
}

void MooseSays(string message)
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}

bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}

void EnthusiasticQuestion()
{
    bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
    if (isEnthusiastic)
    {
        MooseSays("Yay!");
    }
    else
    {
        MooseSays("You should try it!");
    }
}

void LoveCSharpQuestion()
{
    bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
    if (doesLoveCSharp)
    {
        MooseSays("Good job sucking up to your instructor!");
    }
    else
    {
        MooseSays("You will...oh, yes, you will...");
    }
}

void SecretQuestion()
{
    bool wantsSecret = MooseAsks("Do you want to know a secret?");
    if (wantsSecret)
    {
        MooseSays("ME TOO!!!! I love secrets...tell me one!");
    }
    else
    {
        MooseSays("Oh, no...secrets are the best, I love to share them!");
    }
}
// Ask some questions

