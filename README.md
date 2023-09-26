# Berlin Clock- WPF C# Project
# 1. Introduction
Welcome to the Berlin Clock project!<br/> This repository contains a Windows Presentation Foundation (WPF) application written in C# that simulates a Berlin Clock,
also known as the "Berliner Uhr" or "Set Theory Clock."<br/>
- The Berlin Clock is a unique and visually interesting timekeeping device that displays the time using a series of colored lights.
- The clock consists of 24 lights which are divided into one circular blinking yellow light on top to denote the seconds,
two top rows denoting the hours, and two bottom rows denoting the minutes.
- The clock is read from the top row to the bottom.
- The top row of four red fields denotes five full hours each, alongside the second row, also of four red fields, which denote one full hour each, displaying the hour value in 24-hour format.
- The third row consists of eleven yellow-and-red fields, which denote five full minutes each (the red ones also denote 15, 30, and 45 minutes past).
- The bottom row has another four yellow fields, which mark one full minute each.
- The round yellow light on top blinks to denote odd- (when lit) or even-numbered (when unlit) seconds.

In this project, we have implemented a digital version of the Berlin Clock using WPF, which:
- Display the current time in the Berlin Clock format.
- Experience the visual representation of time in an innovative way.

# 2. Prerequisites
- Visual Studio 2022: The above project has been built in Visual Studio 2022 which uses .Net Framework version `.8.09032`.

# 3. Getting Started
Visual Studio 2022 can be downloaded from `https://visualstudio.microsoft.com/downloads/`.

# 4. Running the application
- The project can be cloned from `https://github.com/SriRakshaSArun/berlin-clock.git`.
- Once cloned, the project can be opened by clicking on BerlinClock.sln file. It is a solution file which contains the metadata of the project.
- Set the BerlinClock project as the startup project. The project needs to be built/rebuilt and then can be run/started using the Start green button.
- The UI displays the Berlin clock running and the current time displayed at the bottom.
