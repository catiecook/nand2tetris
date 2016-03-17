// VMtranslator 
// Takes in VM files, translates them 
// Translates the push and pop arguments

//~~~~~~~~~~~~~ PARSER MODULE ~~~~~~~~~~~~~~

//Call Constructor
	//open .asm file
		//creat array of strings with fule data

	//error message if no file present that works

//Call Parseer function
		//remove all white space and comments 
		
//Bool moreCommands() that constantly checks if there are more commands present
	//while(moreCommands();
		//Read next commmand from input file and make current command
		//untill the boolean function moreCommands() is false
		//meaning there are no more commands

		//While there ARE still commands
			//call commandType() to return the type of command encountered. 
					//examples: C_ARITHEMETIC, C_PUSH, C_POP, C_LABEL, C_GOTO, C_IF, C_FUNCTION, C_RETURN, C_CALL
			//call string arg1()
					//return the first argument of current command
					//not called if the current command is C_RETURN because that means its the end 
			// call int arg2()
					//returns second argument of the current command. 
					//Called only if current command is C_PUSH, C_POP, C_FUNCTION, C_CALL 

//~~~~~~~~~~~~~ CODEWRITER ~~~~~~~~~~~~~~

//Call constructor (ostream out)
		//opens output file/stream and prepares to write to it 	
	//setFileName(string fileName) 
			//iterate through data array?
			//Call writeArithmetic (strong command) to write assembly code translated 
			//from given arithemetic commmand
			//Call WritePushPop(pop/push command, string segment, int index)
				//writes assembly code translated from current command, either C_PUSH or C_POP
		//When all lines have been read out
			//close file


//TEGAN STRALEY & CATIE COOK
//FILE: VMtranslator.cs
//PROJECT: created for project 7 of NAND2Tetris course

//File converts .vm input file to hack assmebly code. The resulting code
//in displayed out to user and also written to a corresponding output file. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace VMtranslator
{
    class Program
    {
        //declaration of global variables
        int ARITHMETIC = 0;
        int PUSH = 1;
        int POP = 2;
        int LABEL = 3;
        int GOTO = 4;
        int IF = 5;
        int FUNCTION = 6;
        int RETURN = 7;
        int CALL = 8;
        bool keepGoing;
        int argType;
        string argument1;
        int argument2;
        private int arthJumpFlag = 0;

        

    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    //~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~MAIN~~~~~~~
    public static void Main(string[] args)
    {
            Console.WriteLine("Enter in the .vm file/directory you wish to convert to .asm : ");
            string vmFileName = Console.ReadLine();

            string asmFileNameString = new string(asmFileName);
            string logFileNameString = new string(asmFileName);
            logFileNameString = string.Concat(asmFileNameString, "log"); //making a .log to fill with same as what we Console.WriteLine();
            asmFileNameString = string.Concat(asmFileNameString, "asm"); //.asm is now .hack
            System.IO.StreamWriter fileOutput = new System.IO.StreamWriter(asmFileNameString);
            System.IO.StreamWriter logOutput = new System.IO.StreamWriter(logFileNameString);

            while ((line = file.ReadLine()) != null)
            { //line by line each loop through
                program.parser(line, fileOutput, logOutput);
            }

            Console.ReadLine();

            file.Close();
            fileOutput.Close();
            logOutput.Close(); //this is a text file to store messages and any error messages 
        }//end of main
    }//end of class Program
}//end of namespace



