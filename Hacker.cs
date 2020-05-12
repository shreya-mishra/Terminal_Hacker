using UnityEngine;

public class Hacker : MonoBehaviour
{
    string menuHint=" Type Menu for home page  ";
    string[] level1Passwords={"books","aisle","self","password","font","borrow"};
    string[] level2Passwords={"prisoner","handcuffs","chappati","criminal"};
    string[] level3Passwords={"starfield","telescope","environment","exploration","astronauts"};
    int level;
    enum Screen{MainMenu,Password,Win};
    Screen currentScreen = Screen.MainMenu; 
    string password;

    
    void start()
    {
      
      //Terminal.WriteLine("Type menu for the more options");
        ShowMainMenu();    
    }
    

    
    void ShowMainMenu()
    {
   
        currentScreen = Screen.MainMenu;
        
        Terminal.WriteLine("What would you like to hack?");
        Terminal.WriteLine("Press 1 for Library");
        Terminal.WriteLine("Press 2 for Police Station");
        Terminal.WriteLine("Press 3 for NASA!");
        Terminal.WriteLine("Enter Your Choice");
    }
    void OnUserInput(string input)
    {
        if(input =="menu")
        {

            ShowMainMenu();
        }
        else if(input == "quit"|| input =="close")
        {
            Terminal.WriteLine("Please if you are on web close the tab");
            Application.Quit();
        }
        else if(currentScreen==Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if(currentScreen == Screen.Password)
         {
             CheckPassword(input);
         }
    }
    void RunMainMenu(string input)
    {
        //if(input=="1")
        bool isValidLevelNumber = (input == "1" || input == "2" || input == "3");
        if(isValidLevelNumber)
        {
            
            level = int.Parse(input);
            //StartGame();
            AskForPassword();
        }
        /*else if(input=="2")
        {
            level =2;
            password=level2Passwords[3];
            StartGame();
        }*/
        
        else if(input == "007")
        {
            Terminal.WriteLine("Please choose a valid Level MR Bond");
        }
        else{
            Terminal.WriteLine("WELCOME TO TERMINAL HACKER");
            Terminal.WriteLine(menuHint);
        }
    }

   
    
    void AskForPassword()
    {
       
        //var password;
        currentScreen=Screen.Password;

        
        Terminal.ClearScreen();
      
        SetRandomPassword();
        //Terminal.WriteLine("You have chosen level"+ level);
        Terminal.WriteLine("Please Enter Your Password [hint] :"+password.Anagram() );
    
     
    }
   void SetRandomPassword()
   {
         switch(level)
        {
            
            case 1:
                   int index1=Random.Range(0,level2Passwords.Length);;
                   
                   password=level1Passwords[index1];
                   break;
            case 2:
                      
                   int index2=Random.Range(0,level2Passwords.Length);
                   password=level2Passwords[index2];
                   break;
            case 3:
                    int index3=Random.Range(0,level3Passwords.Length);
                      
                    password=level3Passwords[index3];
                    break;
            default:
                    Debug.LogError("Invalid Level Number");
                    break;
        }
   }
    
    void CheckPassword(string input)
    {
        if(input==password)
        {
           // Terminal.WriteLine("Welldone!");
            DisplayWinScreen();
        }
        else
        {
            AskForPassword();
        }
    }

    void DisplayWinScreen()
    {
        currentScreen=Screen.Win;
        Terminal.ClearScreen();

        ShowLevelReward();
        Terminal.WriteLine(menuHint);

    }

    void ShowLevelReward()
    {
        switch(level)
        {
            case 1:
                    Terminal.WriteLine("Have a Book.....");
                    
                    Terminal.WriteLine(@"
      _________
     /       / /
    /       / /
   /_______/ /
  (_______( /
   "        
             );
             Terminal.WriteLine("Good! Play Again For A Next Level");
            break;
            case 2:
                Terminal.WriteLine("You Got The Prison Key!");
                Terminal.WriteLine(@"
   ___
  /   \________
  \___/-=' = '
  "
                );
                Terminal.WriteLine("Play Again For A Greater Challenge" );
                break;
            case 3:
                Terminal.WriteLine(@"
 _ __  __ _ ___ __ _
| ' _\/_'/ __|/  _ '|  
| | | | (_|\__ \(_| |           |
|_| |_|\_'_|__)\__'_|

 ");
 Terminal.WriteLine("WELCOME TO NASA's INTERNAL SYSTEM!")  ;    
 break;     
             default:
                Debug.LogError("Invalid  level reached");
                break;
              
             

    



        }
    }







    

    
    
    
    
    
    
    
    
    
    
    
    
    
    
    /*string[] level1Passwords = {"books","aisle","password","font","borrow"};
    const string menuHint = "You may type menu at any time";
    string[] level2Passwords = {"prisoner","handcuffs","uniform","arrest"};
    
     int level;
     enum Screen {MainMenu, Password, Win};
     Screen currentScreen;
     string password;
      void Start()
    {
        

        var name="Hello Ben";
        Terminal.WriteLine(name);
        ShowMainMenu();

    }


     void ShowMainMenu()
    {
        currentScreen = Screen.MainMenu;

        //Terminal.ClearScreen();
        Terminal.WriteLine("What would you like to hack?");
        //Terminal.WriteLine();

        Terminal.WriteLine("Diffiulty Levels");

        Terminal.WriteLine("Press 1 - Book");
        Terminal.WriteLine("Press 2 - Prison");
        Terminal.WriteLine("Press 3 - ");
        Terminal.WriteLine("Enter Your Choice");
    }

     void RunMainMenu(string input)
    {
        bool isValidLevelNumber=(input == "1"|| input =="2");
        bool isValidLevelNumber=(input == "1"|| input=="2"||input =="3");
        if(isValidLevelNumber)
        {
            level = int.Parse(input);
            StartGame();
            AskForPassword();
        }


             /*if(s=="1")
            {
                level=1;
                password="donkey";
                StartGame();
            }
            else if(s=="2")
            {
            
                level=2;
                password="monkey";
                StartGame();
            }
            else if(s=="3")
            {
                password="dog";                 
                level=3;
                StartGame();
            }

            else if(input=="007")
            {
                void RunMainMEnu(string input);
               // Terminal.WriteLine("Please select a level mr Bond!");
           
            }
            else
            {
                Terminal.WriteLine("Please choose avalid level");
                Terminal.WriteLine(menuHint);
            }
    }
               
         
    
    

   
    void AskForPassword()
    {
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        //switch(level)
        setRandomPassword();
        Terminal.WrteLine("Enter Your Password Hint: "+ password.Anagram());
        //Terminal.WriteLine(menuHint);
    }

    void setRandomPassword()
   // void startGame()
    {
        switch(level)
        {
            case 1:
                   //password=level1Passwords[0];
                   password=level1Passwords[Random.range(0,level1Passwords.Length)];
                   break;
            case 2:
                  // password=level2Passwords[1];
                   password=level2Passwords[Random.range(0,level2Passwords.Length)];
                   break;
            case 3:
                    password=level3Passwords[setRandomPassword(0.level3PAsswords.Length)];

            default:
                    Debug.LogError("Invalid level number");
                    break;
            
        }
       // Terminal.WriteLine("You have chosen level "+ level);
        //Terminal.WriteLine("Please Enter Your Password : "+password.Anagram());
    }
    

    
   
    void OnUserInput(string input)
    {
        //Terminal.WriteLine("Your Name?");

         string s=input;
         if(s=="menu")
         {
            ShowMainMenu();
         }
         else if(currentScreen==Screen.MainMenu)
         {
             RunMainMenu(s);
         }
         else if(currentScreen== Screen.Password)
         {
             CheckPassword(input);
         }
    }
    

         
         

    
    void StartGame()
    {

    }
    

    
    
    
    void CheckPassword(string input)
    {                                      
        if(input==password)
        {
            Terminal.WriteLine("Welldone!");
            DisplayWinScreen();
        }
        else{
            Terminal.WriteLine("Sorry Password is incorrect!");
            AskForPassword();
            
        }
    } 

    void DisplayWinScreen()
    {
        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        ShowLevelReward();
        Terminal.WriteLine(menuHint);
    }
    void ShowLevelReward()
    {
        switch(level)
        {
            case 1:
            Terminal.WriteLine("Have a book");
            Terminal.WriteLine("Have a aisle");
            Terminal.WriteLine("Have a aisle");
            Terminal.WriteLine("Play again after for a greater challenge.");
            break;
            case 2:
            Terminal.WriteLine("You got the prison key!");
            Terminal.WriteLine("Welcome to NASA's internal System");
            break;
            default:    
                Debug.LogError("Invalid reached");
                break;
        }
    }*/
}
