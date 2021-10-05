gifskiWinGUI v0.0.1

By Ashe Sterling

Usage: A GUI Wrapper for ImageOptim's gifski Command-Line utility implementation for Windows.

___I am brand new to C#, and haven't coded in about a decade, and that was just CLI Python stuff, so go easy on me. But, if anyone has any tips or recommendations, I would be happy to listen in the issues forum( or hit me up on Twitter, or something).___

------Installation------

-Put gifskiWinGUI.exe and gifski.exe in the same folder. 

-Run gifskiWinGUI.exe

------Instructions------

-Put all of the image frames that will be used to render your animation into a separate folder. (Note: this is because this program automatically uses all files within the selected folder for the animation.)

-Navigate to that folder using the "Browse..." button next to the Source Frames box. 

	-Alternatively, type the directory for the folder into the Source Frames box.

-Determine what size you want your output .gif to be. The program uses the size of the first image in the sequence by default, which will be displayed when you first choose the directory.

-Determine the Frames per Second you would like the output animation to play at. (Note: you can choose higher than the default of 50 [up to 100], but 50 is the maximum that modern browsers will support. If you upload a gif with a higher FPS than 50, it will play at 10 FPS.)

-Determine the quality you want the output animation to be (1-100), and select it.

-Set the output destination at the bottom either using "Browse..." or the text box to type it in (Note: you need to type in a file name in addition to the folder directory.)

-Once you've done all of this, just click "Render," and gifski will be ran with the arguments resulting from the previous steps.
