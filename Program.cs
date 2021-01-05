using System;

namespace GeneralPerpouseConsoleApplication
{
          class Program
          {
                    static void Main(string[] args)
                    {
                              //General Window Formatting
                              Console.Title = "General_Perpouse_Console_Application";
                              Console.ForegroundColor = ConsoleColor.Green;

                              //Starting the programm

                              var application = true;
                              while (application == true)
                              {
                                        //UserID    
                                        Console.WriteLine("UserID:");
                                        var userid = Console.ReadLine();
                                        var person = "TestBot";
                                        if (userid == "Test")
                                        {
                                                  var wordofpassage = true;

                                                  while (wordofpassage == true)
                                                  {
                                                            //Variable called password
                                                            Console.WriteLine(" ");
                                                            Console.WriteLine("Passowd:");
                                                            var password = Console.ReadLine();

                                                            if (password == "abc123")
                                                            {
                                                                      //Welcoom back and help function message 
                                                                      Console.ForegroundColor = ConsoleColor.White;
                                                                      Console.WriteLine(" ");
                                                                      Console.WriteLine("Welcome back " + person + "!");
                                                                      Console.WriteLine("What would you like to do first?");
                                                                      Console.WriteLine("Type .help to open the help menu and see what we can do.");
                                                                      Console.WriteLine(" ");
                                                                      Console.ForegroundColor = ConsoleColor.Green;

                                                                      //Functionality for all the functions
                                                                      var run = true;
                                                                      while (run == true)
                                                                      {
                                                                                var input = Console.ReadLine();
                                                                                if (input == ".help")
                                                                                {
                                                                                          Console.ForegroundColor = ConsoleColor.White;


                                                                                          Console.WriteLine(" ");
                                                                                          Console.WriteLine("These are all the thing you can do with this application");
                                                                                          Console.WriteLine(" ");
                                                                                          Console.WriteLine(".passwordgen   -   This will generate a secure password.");
                                                                                          Console.WriteLine(".randletter    -   This will generate a random letter.");
                                                                                          Console.WriteLine(".randomnum     -   This will generate a random number.");
                                                                                          Console.WriteLine(".logout        -   This will log you out and close the window.");
                                                                                          Console.WriteLine(".about         -   This will tell you more about the application.");
                                                                                          Console.WriteLine(".gmail         -   This will give you the link for your mail.");
                                                                                          Console.WriteLine(".clear         -   This will clear all past conversations.");
                                                                                          Console.WriteLine(".beep          -   This will play a beep sound.");
                                                                                          Console.WriteLine(".help          -   This will display this help menu.");
                                                                                          Console.WriteLine(".kill          -   This will terminate the programm.");
                                                                                          Console.WriteLine(".dev           -   This will tell you more about the dev.");
                                                                                          Console.WriteLine(" ");
                                                                                          Console.WriteLine("There are also plenty of hidden easter eggs in this application\nTry to find them...\nDon`t worry if you get an 404-error message...");
                                                                                          Console.WriteLine(" ");

                                                                                          Console.ForegroundColor = ConsoleColor.Green;
                                                                                }

                                                                                else if (input == ".passwordgen")
                                                                                {
                                                                                          Console.ForegroundColor = ConsoleColor.White;

                                                                                          Console.WriteLine(" ");
                                                                                          var p1 = "A3c!x4c";
                                                                                          var p2 = "A7fi%dn";
                                                                                          var p3 = "B1s3*cw";
                                                                                          var p4 = "Bji!hVc";
                                                                                          Console.WriteLine("A few passwords are:");
                                                                                          Console.WriteLine(p1);
                                                                                          Console.WriteLine(p2);
                                                                                          Console.WriteLine(p3);
                                                                                          Console.WriteLine(p4);
                                                                                          Console.WriteLine(" ");
                                                                                          Console.WriteLine("Note that these password are not meant to be used for any serious perpouse");
                                                                                          Console.WriteLine("Seriously guy, do not use these password made by a kid writing c#");
                                                                                          Console.WriteLine(" ");

                                                                                          Console.ForegroundColor = ConsoleColor.Green;
                                                                                }

                                                                                else if (input == ".randomnum")
                                                                                {
                                                                                          Console.ForegroundColor = ConsoleColor.White;

                                                                                          Console.WriteLine(" ");
                                                                                          Random randomnuber = new Random();
                                                                                          var randnum = randomnuber.Next(1, 100);
                                                                                          Console.WriteLine("Here is your random nuber \n" + randnum);
                                                                                          Console.WriteLine(" ");

                                                                                          Console.ForegroundColor = ConsoleColor.Green;
                                                                                }

                                                                                else if (input == ".koolkidlang")
                                                                                {
                                                                                          Console.ForegroundColor = ConsoleColor.White;

                                                                                          Console.WriteLine(" ");
                                                                                          Console.WriteLine("WOW\n ustwow, that is increlible.\nI really did not expect you to find this easter egg\nBut you proved yourself worthy to carry on the quest");
                                                                                          Console.WriteLine(" ");
                                                                                          Console.WriteLine("Find the next easter egg it has nothing to do wit dis one");
                                                                                          Console.WriteLine("LOL");
                                                                                          Console.WriteLine(" ");

                                                                                          Console.ForegroundColor = ConsoleColor.Green;
                                                                                }

                                                                                else if (input == ".randletter")
                                                                                {
                                                                                          Console.ForegroundColor = ConsoleColor.White;

                                                                                          Console.WriteLine(" ");
                                                                                          char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
                                                                                          Random randletters = new Random();
                                                                                          Console.WriteLine(letters[randletters.Next(0, 25)].ToString());
                                                                                          Console.WriteLine(" ");

                                                                                          Console.ForegroundColor = ConsoleColor.Green;

                                                                                }

                                                                                else if (input == ".error")
                                                                                {
                                                                                          Console.ForegroundColor = ConsoleColor.White;

                                                                                          Console.WriteLine(" ");
                                                                                          Console.WriteLine("Wow you just found the one and only easter egg in this application");
                                                                                          Console.WriteLine("We are so extremely proud of you...");
                                                                                          Console.WriteLine("So much so that we will give you a hint for another easter egg");
                                                                                          Console.WriteLine(" ");
                                                                                          Console.WriteLine("Here is your hint...\nFind the lang... \nda, dis, dat, kool, skool");
                                                                                          Console.WriteLine(" ");

                                                                                          Console.ForegroundColor = ConsoleColor.Green;
                                                                                }

                                                                                else if (input == ".edit")
                                                                                {
                                                                                          Console.WriteLine("asdf");
                                                                                }

                                                                                else if (input == ".lol")
                                                                                {
                                                                                          Console.ForegroundColor = ConsoleColor.White;

                                                                                          Console.WriteLine(" ");
                                                                                          Console.WriteLine("LOL indeed\nWow you have so much potencsial in you\n maybe you would be a professional easter egg expoiter someday");
                                                                                          Console.WriteLine("If that is a read job...");
                                                                                          Console.WriteLine(" ");

                                                                                          Console.ForegroundColor = ConsoleColor.Green;
                                                                                }

                                                                                else if (input == ".clear")
                                                                                {
                                                                                          Console.Clear();
                                                                                          Console.WriteLine(" ");
                                                                                }

                                                                                else if (input == ".gmail")
                                                                                {
                                                                                          Console.ForegroundColor = ConsoleColor.White;

                                                                                          var gmail = "https://mail.google.com";
                                                                                          Console.WriteLine(gmail);

                                                                                          Console.ForegroundColor = ConsoleColor.Green;
                                                                                }

                                                                                else if (input == ".about")
                                                                                {
                                                                                          Console.ForegroundColor = ConsoleColor.White;

                                                                                          Console.WriteLine(" ");
                                                                                          Console.WriteLine("This is a General perpose application devoloped by a kid writing c# as he has nothing better to do with his time.\nThis started out as a small project and then devoloped into a full time devolopment application");
                                                                                          Console.WriteLine(" ");
                                                                                          Console.WriteLine("Here is the legal and thakyou file");
                                                                                          Console.WriteLine(" ");
                                                                                          Console.WriteLine(" ");
                                                                                          Console.WriteLine("I want to thank you for devoting yourtime to reading this.");
                                                                                          Console.WriteLine(" ");
                                                                                          Console.WriteLine("With this document i wanted to tell you thanks mainly that you spen time out of your day for opening and reading this document and also using this application.");
                                                                                          Console.WriteLine(" ");
                                                                                          Console.WriteLine("Moving onto legal matter this is an open source royalty free programm that i wrote as a personal project just to sharpen my c# skills(see what i did there?). Any way one you get your hands on this programm you are free to coustemize it how ever you like. But if you use the original version you must credit 'Unstoppable'.");
                                                                                          Console.WriteLine(" ");
                                                                                          Console.WriteLine("I myself do not like reading big paragraph so i am going to break it down in ponits :\n	- You can not put off the programm as your own unless you make noticeable changes.\n	- You must credit 'Unstoppable' for the basic code\n			It dosent need to be fancy just a quick 'thanks to unstoppable for the basic stucture and framework'");
                                                                                          Console.WriteLine(" ");
                                                                                          Console.WriteLine("If you follow those rules then you are okay to use this programm and again thanks for the time.");
                                                                                          Console.WriteLine(" ");

                                                                                          Console.ForegroundColor = ConsoleColor.Green;
                                                                                }

                                                                                else if (input == ".logout")
                                                                                {
                                                                                          Console.Beep();
                                                                                          Console.Clear();
                                                                                          wordofpassage = false;
                                                                                          run = false;
                                                                                }

                                                                                else if (input == ".beep")
                                                                                {
                                                                                          Console.Beep();
                                                                                }

                                                                                else if (input == ".kill")
                                                                                {
                                                                                          Console.ForegroundColor = ConsoleColor.Red;
                                                                                          Console.BackgroundColor = ConsoleColor.White;
                                                                                          Console.WriteLine("Terminating Programm");
                                                                                          Console.Beep();
                                                                                          run = false;
                                                                                          wordofpassage = false;
                                                                                          application = false;
                                                                                }

                                                                                else if (input == ".dev")
                                                                                {
                                                                                          Console.WriteLine("This application has been devoloped by a kid on a");
                                                                                }

                                                                                else
                                                                                {
                                                                                          Console.ForegroundColor = ConsoleColor.Red;
                                                                                          Console.BackgroundColor = ConsoleColor.White;

                                                                                          Console.WriteLine(" ");
                                                                                          Console.WriteLine("404 ERROR\nWe could not understand what you said.\nPlease try typing '.help' to see the help menu");
                                                                                          Console.WriteLine(" ");

                                                                                          Console.ForegroundColor = ConsoleColor.Green;
                                                                                          Console.BackgroundColor = ConsoleColor.Black;
                                                                                }
                                                                      }

                                                            }

                                                            else if (password == ".kill")
                                                            {
                                                                      Console.ForegroundColor = ConsoleColor.Red;
                                                                      Console.BackgroundColor = ConsoleColor.White;
                                                                      Console.WriteLine("Terminating Programm");
                                                                      Console.Beep();
                                                                      wordofpassage = false;
                                                                      application = false;
                                                            }

                                                            else
                                                            {
                                                                      Console.WriteLine(" ");
                                                                      Console.WriteLine("Wrong password \nPlease try again");
                                                                      Console.WriteLine(" ");
                                                            }

                                                  }

                                        }

                                        else if (userid == ".kill")
                                        {
                                                  Console.ForegroundColor = ConsoleColor.Red;
                                                  Console.BackgroundColor = ConsoleColor.White;
                                                  Console.WriteLine("Terminating Programm");
                                                  Console.Beep();
                                                  application = false;
                                        }

                                        else
                                        {
                                                  Console.WriteLine(" ");
                                                  Console.WriteLine("Sorry we dont recogonise you... \nPlease try again");
                                                  Console.WriteLine(" ");
                                        }

                              }
                    }
          }
}
