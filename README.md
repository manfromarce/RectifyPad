<p align="left">
    <img src="https://raw.githubusercontent.com/Lixkote/RectifyPad/master/logo.png">
</p>

RectifyPad is a modern and unofficial replacement for WordPad, written in C#. It is free and open source, and aims to provide almost the same functionality as its predecessor, with a fresh and updated look.

![RectifyPad Screenshot](https://github.com/Lixkote/WordPad11/blob/main/darkpreview.png)
![RectifyPad Screenshot](https://github.com/Lixkote/WordPad11/blob/main/lightpreviewnew.png)

## Features
- Standard WordPad features, such as basic text operations and inserting various multimedia items.
- Modern Windows 11-style design, based on the new paint redesign.

## Acknowledgements
I would like to thank the following people for their contributions and inspiration:
 - [Jd](https://github.com/Jd-1206) for the initial concept and visual recreation of the lost application.
 - [WinEX](https://github.com/WinExperiments) from the Rectify11 Team for helping me with icon design and other aspects.

## Getting started
To run RectifyPad, you will need the following prerequisites:
- A computer running Windows 11 21H1, build 22000 or newer (Windows 10 support will be coming soon).
- The latest version of [Visual Studio](https://developer.microsoft.com/en-us/windows/downloads) (the free community edition is sufficient).
  - The "Universal Windows Platform Development" workload installed.
  - The latest Windows 11 SDK and Windows 10 SDKs installed.


- The source code of RectifyPad, which you can get by cloning this repository:
    ```
    git clone https://github.com/Lixkote/RectifyPad
    ```

- Open [src\WordPad.sln](/src/WordPad.sln) in Visual Studio to build and run the RectifyPad app.
- To test the app, compile it and run it in debug mode.

## Contributing
If you want to contribute to RectifyPad, please contact me on the official Rectify11 Discord.

## Projects used
 - [TowPad](https://github.com/itsWindows11/TowPad) for some of the mechanics.
 - JD's lost WordPad Recreation for the initial idea.
 - [Ivirius Text Editor Free](https://apps.microsoft.com/detail/9mv281zzf51p?hl=pl-pl&gl=TW) for the ruler code.
 - [Appxinstaller](https://github.com/aL3891/AppxInstaller/tree/master) for converting appx into msi.
 - [Syncfusion Doc.IO UWP](https://www.nuget.org/packages/Syncfusion.DocIO.UWP/19.2.0.51) for docx and doc support.

## TO-DO
  - Improve functionality.
  - Possibly Implement OLE (Object Inserting and Embedding).
  - Improve stability.
  - 
  
RectifyPad is licensed under the [MIT License](./LICENSE).
