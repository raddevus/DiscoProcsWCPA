
<img align="left" src="https://allos.dev/assets/wcpabook.png" >


### Read the FREE Book & Get the FOSS Software
You can begin reading Writing Cross-Platform Apps (For Discovery & Learning) below. 
Also, check out my web site for updated info and blog entries: https://allos.dev/blog/

## Does Anyone Still Want To Learn To Program?
I've been writing software applications and creating automated solutions for over 30 years now and I still love to write code to create software solutions.

Does anyone else still want to learn to write applications or do they just want the end result?

## What Is This Book (Article Series) About?
I hope so, because this book is entirely dedicated to teaching you how to write code so you can create applications that run on all three major Operating System (OS) Platforms (Linux, macOS, Windows).

## What App Will We Build In This Book (Article Series)?
We will create a cross-platform TaskManager which will allow you to examine running processes (apps) on any computer.  You can see the final result further along in this chapter and you can get all the source code for free.  More on all of this but first, let's talk about end results.

## Companies Want The End Result
Companies, which must produce more money than they burn, in order to survive, just want the end result.  They don't care how they get to the end result, they just want The Thing and they want it cheaper.  The most expensive thing for a company is an employee.

To those companies, an employee is just a resource, like any desk, chair or keyboard that the company owns.  When the chair breaks or keyboard no longer works the way the company expects, then they throw it out and get another.  Unfortunately, you, as an employee, are seen the same way as the chair.

## Focusing On End Result: Good For Companies, Bad For Employees
Companies are all-in on AI because they just want the result.

If you have little experience, then you too may be extremely excited about AI.  You may finally be able to create that little app you've always wanted to create but never could because you never learned to program.

It may feel quite satisfying to get to the result that you've dreamed about for so long.  I understand that.  

## Satisfaction: Directly Proportional To Effort Applied

But, it is likely that you'll soon discover that it's not terribly satisfying because satisfaction of accomplishing a task is directly proportional to the amount of effort required to obtain the result.

## Why Would Anyone Want To Learn In The Age of AI?

If everyone can just get to the end result then who will care about the process?

If everyone can just write apps, then why does the process of writing code matter?

Why would anyone want to do anything that AI can do for them?

## When AI Can Do Everything, Humans Will Lose Purpose

Will there be an even greater loss of purpose for humans?  Probably.

Many people have a shallow belief that "work is bad" but that's not exactly correct.  

A better statement would be: "bad work is bad".

Here's a supporting quote from the book, Reality Is Broken: Why Games Make Us Better and How They Can Change the World, by Jane McGonigal  (Check it out at Amazon: https://amzn.to/3H20ioM)

<blockquote>"Games make us happy because they are hard work that we choose for ourselves, and it turns out that almost nothing makes us happier than good, hard work."</blockquote>

Maybe you don't believe work makes you happy.  Take a look at any four year old child who is intently playing and you'll see that they are so serious about playing that it is as if they are working.  It's good work.

Jane McGonigal goes on to say:

<blockquote>Brian Sutton-Smith, a leading psychologist of play, once said, “The opposite of play isn’t work. It’s depression.”</blockquote>

And it's true.

A lack of work doesn't create happiness.  The ability to work on the things that bring you enjoyment does.

Why do I still (after 30 years) like to write code and create software solutions?  What is it that makes it so satisfying?

For me, it's all about Discovery and Learning.  I've always wanted to know how things work and I still do.  How about you?

## Discovery and Learning

I recently wrote a cross-platform (Linux, macOS, Windows) TaskManager using C# .Net 8.x / 9.x*, for the two reasons I like to write any software:

* **Discovery** - find out what is possible with the technologies I'm using to build the app

* **Learning** - learn more about how technologies work (and don't)

If you like to discover and learn things, then you'll always be satisfied with programming, because the discovery and learning never stops.  That's what makes it such an exciting industry.

If you want to "arrive", don't choose software development as a thing, because there's no final destination.  You'll never learn everything, and that's a good thing.

## UI: HTML, CSS (Bootstrap) and React
The User Interface for **DiscoProcs** was written in HTML, CSS (using Bootstrap), JavaScript and React for some grid views.

Here's what it looks like.  It's nowhere near perfect, but I keep working on the UI to make it better.  (There's even a right-click context menu – which I had to build in HTML/CSS – which gives the user more functionality.)
<img src="/assets/blog/discoProcsMainForm.png">

## Follow Along and Learn

Are you interested in learning C# .Net Core, how to build a WebAPI, HTML, CSS (including Bootstrap), JavaScript, ReactJS, Git and some other things? 

If you are interested, follow along and I'll take you step-by-step through how to build the app.  

By the time you work your way through this series of articles, you will have gained a lot of knowledge about how to build a cross-platform app using C#.  You'll also have a complete TaskManager application which you can run anywhere (Linux, macOS, Windows10/11).  

## Get The Source Code At GitHub
All the source code is FOSS (Free & Open Source Software) so you can alter the code and use it anywhere you like.  You can get the source code right now at: https://github.com/raddevus/DiscoProcs

## Run The App, Learn About System Processes & More

You can get the executable DiscoProcs app and run it on your system right now.

Just go to my web site and follow the instructions for your Operating System (OS):

https://allos.dev/downloads

Here's a list of what the cross-platform TaskManager will allow the user to do:

* **View all processes** which are running on the computer

* **View process details**, including  => 

    1. Process name,  PID (Process ID) ID the OS assigns to the running process,  

    2. Path to location where executable is running from, 

    3. Exe file date (used as a way to track when the file changes), 

    4. Exe File size (on disk), 

    5. Number of bytes the running process takes in memory, 

    6. SHA-256 hash of the exe file (allows us to fingerprint the Exe so we can identify it) – we will learn all about this as we write the code

* Stop any running process

* **View the Process History** - Since we take a SHA-256 of each EXE file, we save the history of each file as it changes on your system and you'll be able to determine when a process changed on your computer.

* **Save a Process Snapshot** - save all processes & related data to a local Sqlite database

* **Display a list of all the modules** (program functionality wrapped in code libraries) that the program uses

* **Display New Processes** - Once you take a Process Snapshot, you can then run [Show New Procs] functionality and it will examine all the running processes, compare them to the ones that you've stored in the local Sqlite database and determine if they've been captured in the past.  This can give the user an idea of processes that are running that haven't run in the past & provides insight to possible changes to the system.

* **Quick Start Any App** - Add a list of programs you'd like to start then later you can start all of them at once if you like.  Or, you can add parameters to an app that you'd like to start in a particular state and start the app in that state.

* **Display all SpecialFolders** - special folders are locations where the current user can save files and run apps from. These are defined on all platforms (Linux, macOS, Windows) and it can be very helpful to know where they are for discovering where files are located.

* **Display Environment Variables** - Environment variables are Operating Systems values which are used by various running processes. 

Are you still interested in learning to write apps?  Are you interested in learning C#?

## Who Is This Book For?

This book is for anyone who is interested in learning to write C# code to create complete applications.  

Even if you're a beginner you'll be able to work through the book.  

## There Will Be Challenging Things To Do

However, I don't hold your hand.  There are going to be some things that I tell you to go and do and you'll have to do them.  Not programming things, but things you have to do so you can program.

I'm not going to waste time telling you how to do these things.  For example:

You're going to need to know how to get around on the command line (also known as console or terminal) of your OS (operating system).  

1. Very basic commands so you can see a list of files or run the dotnet tool (included with .NET SDKs)

2. You'll need to have some kind of simple code editor on your computer 

    * I use neovim text-based editor (https://github.com/neovim/neovim)

    * I've used VS Code (https://code.visualstudio.com/) in the past and it is a good choice

    * You can use whatever you want, but I'm not going to walk you through all that

3. You need to install the .NET (Core) https://dotnet.microsoft.com/ SDK & Runtime on your machine

    * There are numerous ways to install it and this is your first test.

Once the dotnet sdk is properly installed you'll know because you'll be able to run: 

<code>dotnet --version</code>

Then you'll see valid output displaying the dotnet tool version.

## Basic Computer Skills
You don't need anything more than basic computer skills I've talked about above.
So, are you ready?

## Let's Get Started, Writing Reusable Code

I hope so.  If you are, let's get started writing code in the next chapter.  We will begin creating the core functionality in a C# .dll (dynamic link library) which will allow us to easily use the functionality from other apps (WebAPI, console apps, etc.).
