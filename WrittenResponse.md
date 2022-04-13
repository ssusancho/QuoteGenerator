# Quote Generator Written Response

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.
Describes the overall purpose of the program

The purpose of the program is to give a person a random quote depending on their mood. 

### 3a ii.
Describes what functionality of the program is demonstrated in the video.

Quote Generator displays a quote depending on what type of quote the player chooses. The player can choose from different catagories of quotes.


### 3a iii.
Describes the input and output of the program demonstrated in the video.

The input is a number according to the category the player wants, and the output is a random quote from that topic. 

## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.

### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp
           List<string> quoteNames = new List<string>();
            quoteNames.Add("Funny");
            quoteNames.Add("Sad");
            quoteNames.Add("Inspirational");
```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
foreach (string name in quoteNames)
            {
                
                Console.WriteLine($"{ix}. {name}");
                ix = ix + 1;
            }
```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

The list is stored in the variable quoteNames

### 3b iv.

Describes what the data contained in the list represents in your program

The list contains the category names of the different types of quotes. 

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or **how it would be
written differently**, if you did not use the list.

Without this list, I would have to individually program a number to be assigned to a new category if I wanted to add more options. I would have to manually add a bunch of if and else statements for each category. With my list, I can easily add more sections that will automatically have a corresponding number to it that the player can enter.

## 3c.

Capture and paste two program code segments you developed during the
administration of this task that contain a student-developed procedure that
implements an algorithm used in your program and a call to that procedure.

### 3c i.

The first program code segment must be a student-developed procedure that:

- [ ] Defines the procedure's name and return type (if necessary)
- [ ] Contains and uses one or more parameters that have an effect on the functionality of the procedure
- [ ] Implements an algorithm that includes sequencing, selection, and iteration

```csharp
 public static int DisplayQuoteOptions(List<string> quoteNames)
        {

            if (quoteNames == null) throw new ArgumentException("List of options may not be null.");
            if (quoteNames.Count == 0) throw new ArgumentException("The list of options must contain at least 1 option.");

            

            int ix = 1;
            foreach (string name in quoteNames)
            {
                
                Console.WriteLine($"{ix}. {name}");
                ix = ix + 1;
            }

            int userChoice;
            do{
            Console.Write("Enter the number in front of your choice:");
            string input = Console.ReadLine();
            bool isANumber = int.TryParse(input, out userChoice);
            if (isANumber == false)
            {
                Console.Error.WriteLine("You did not enter a number.");
            }
            else if (userChoice > quoteNames.Count)
            {
                Console.Error.WriteLine("That number was greater than the options displayed.");
            }
            else if (userChoice <= 0)
            {
                Console.Error.WriteLine("That number was less than the options displayed.");
            }
            }
            while (userChoice > quoteNames.Count || userChoice <= 0);
            return userChoice;
        }
```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp
 int userChoice = DisplayQuoteOptions(quoteNames);
```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

This method numbers each element in quoteNames. Then it displays the number and topic and allows the player to enter the number they want. It throws exceptions if the player's input is less than or more than the number of options. This procedure is essential to my program because it displays the options for the player's input. After choosing a topic using this method, the program accesses a list with all the quotes in that topic and displays one. 

### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

**TODO: In English, explain step by step what your procedure does. Be sure to use the word `Selection` and `Iteration` to explain what it does.**
1. DisplayQuoteOptions iterates through each name in the list quoteNames to write a number with it. 
2. It asks the user to enter a number that corresponds to the choice they want. 
3. Then my method converts the user input into an integer.
4. This repeats if the user input is a number greater than the number of options or less than/equal to zero because this is outside the number of options I have available. 

## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call:

// emptyList contains no elements
DisplayQuoteOptions(emptyList)

Second call:

DisplayQuoteOptions(null)

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:
 
Tests what happens if the List contains no elements

Condition(s) tested by the second call:

Tests if quoteNames does not exist

### 3d iii.

Result of the first call:

The result of emptyList will make the program read "The list of options must contain at least 1 option."

Result of the second call:

The result of calling nothing will make the program read "List of options may not be null."