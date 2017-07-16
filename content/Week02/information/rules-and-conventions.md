---
layout: default
semester: Semester 17B
coursecode: COMP5202
coursename: Fundamentals of Programming
permalink: /week02-rules
---

# Week 02:
## Rules, Conventions, Variables, Operators and Decisions

<a href="./week02-index.html" class="btn btn-default">Week 2 Topics</a> 

---

# Rules and Conventions

When we code our programme or a part of it, you will do in a certain language
This language may be determined by the team you are in or join 

But before that the language is determined by who you are making the application for

At this stage we haven’t seen much code yet - only a little bit in C#, but you will start seeing some examples.

One thing you may have notice when you look at code is that

`All the lines have an equal amount of width`

This makes your code easy to read when it comes to spacing. 

**ALL THE LANGUAGES USE THIS LOOK**  

The colour of the text is also specific, code editors often have this built in to help us read our code better and we can easily scan what we are looking for.

## Code Editors (IDE)

To code a program, or a website or anything really - the only thing we need is a plain text editor

* On windows we can use Notepad
* On macOS we can use Textedit
* On linux (Ubuntu) we can use gedit in the GUI or VIM when using the commandline

Programs like Microsoft Word, Apple Pages are document editors - do not use those to edit your code in.
The idea of a text editor is that it does not provide any fancy formatting, there are many code editors around and you are free to pick the one that suits your needs.

The drawback of plain text editors is that they do not provide any support for syntax, autocompletion or code-formatting

For this course we will use **Visual Studio Code**
It is free and is able to be used on any platform with the same experience

## Keywords

Program languages use keywords extensively to perform certain key tasks

For example `var` is used to define a variable.

Many program language share a common base of these keywords, but some have others added to them, or are case-sensitive. 

Keywords cannot and should not be used as a variable names or in other parts of your program, since it may confuse the compiler.

## Casing

Casing is more important in some languages, which are case sensitive.  

C# and Swift are Case Sensitive  
JavaScript is not Case Sensitive  

> NOTE: keywords are mostly case-sensitive, even if the variable names are not.
If you are wanting to set a variable with the value true (boolean type) then check if the language requires this word to be written with lowercase. You will need to check with each language what type they are

Unlike the languages we write from day-to-day we do not write sentences in programming - we write statements and commands

Statements and commands, do not adhere to the same grammar rules.  
*We do not start them with a capital letter and end them with a full stop.*

## Ending Statements
Most languages end a statement by using a `;`(semicolon)
In some cases this is not required - so again check again what applies to the language you use.

The semicolon applies to most languages that are used today. Some older languages use other symbols.
Swift and JavaScript do not require anything at the end.

## Using Brackets

The use of brackets is very common and used a lot in many languages.
* `( )` = Parenthesis
* `[ ]` = Square Brackets
* `{ }` = Curly Braces (Brackets)

These always come in pairs, what you open by using the left symbol must be matched by a closed by the right symbol. 

Code placed inside of the brackets are known as code blocks.
You are able to nest code blocks and the closing brackets are closed in the reverse order that they are opened in.

The example below shows the use of multiple brackets in a simple if statement.
The language is JavaScript.

[Using Brackets](http://codepen.io/jk11/pen/RKoYwv?editors=0010#0)
