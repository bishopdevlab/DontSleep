# Don't Sleep

The Don't Sleep provides the ability to set the screen saver and sleep mode on a Windows desktop PC.

## Usage

 * Block Screensaver
 * Block Sleep/Hibernate mode
 * Block Screensaver and Sleep/Hibernate mode
 * Unblock
 * In addition, it provides a function to automatically move the mouse. Move the cursor to the side and then move it back to its original position.

![Screenshot of Don't Sleep](/assets/images/README/README_2020-09-16-22-36-00.png)

## Troubleshooting Don't Sleep builds

* Block the resource file

    ```
    Couldn't process file MainForm.resx due to its being in the Internet or Restricted zone or having the mark of the web on the file. Remove the mark of the web if you want to process these files.
    ```
    * Solution: [링크](https://stackoverflow.com/questions/51348919/couldnt-process-file-resx-due-to-its-being-in-the-internet-or-restricted-zone-o "stackoverflow.com")

    * The simplest solution is to right-click the file in Windows Explorer, select Properties, and along the bottom of this dialog, you should have an "Unblock" option. Remember to click OK to accept the change. Relaunch visual studio to load the source code.
