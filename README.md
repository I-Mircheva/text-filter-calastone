# CALASTONE Text Filter Console Application

CALASTONE :bank: :chart_with_upwards_trend: technical challenge for Text Filter by Ivona Mircheva :scroll:

This application implements a simple Text Filter:
> Read from a txt file  
Create and apply the following 3 filters:  
Filter1 – filter out all the words that contains a vowel in the middle of the word – the centre 1 or 2 letters
("clean" middle is ‘e’, "what" middle is ‘ha’, "currently" middle is ‘e’ and should be filtered, "the", "rather"
should not be)  
Filter2 – filter out words that have length less than 3  
Filter3 – filter out words that contains the letter ‘t’  
After all filters have completed display the resulted text in the console  
## Getting Started :zap:
To run the project you'll need to navigate to the MainTextFilter class and specify:
1. Input File path :file_folder:

Then, to run the script use your favourite IDE.

## How the code works in detail :bulb:
The code runs through the following logic: 
* Open and read input file
* Convert file lines to string in OutputText
* Apply the desired filters in order :orange_book:
* Display the output in the console

## Running the tests :heavy_check_mark:
The tests are located in the test folder.

I wrote tests for the filter methods.

To achieve full test coverage, it’s best to also add tests with mocks for the main classes.
## Built With
* C#
## Author
* **Ivona Mircheva** :fox_face: - [I-Mircheva](https://github.com/I-Mircheva)
* Commit messages emojis :art: from [here](https://gitmoji.carloscuesta.me)
