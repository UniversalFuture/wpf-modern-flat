# wpf-modern-flat v2.0
A modern flat UI in WPF.

*Version 2.0 is officially **in development**!*
*Check out the **master** branch to see the old source.*

#Planned Changes
See the [roadmap](roadmap.md).

#What is this?
Basically, it's a WPF theme that lets you create modern-looking programs with no hassle whatsoever. You can't resize the windows right now, but if enough people like it that I can further this project, that will be the first change I implement.

It's open source, so feel free to contribute if you want.

There are some cool things this theme includes that you might consider making use of:
*	Cool buttons, woohoo!
*	Colors from Flat UI
*	Flat textboxes and tabitems support LeftContent and RightContent, which allows you to easily add additional functionality to your controls without stressing over extra code
*	It's customizable, so you can easily change what you don't like
*	Buttons and textboxes have a Bootstrap-like type attribute, which enables them to be quickly and consistently colored

#Screenshots
![Flat Browser POC](/screenshots/flatbrowserpoc.PNG)

![Buttons](/screenshots/buttons.PNG)

![Inputs](/screenshots/inputs.PNG)

#Installation
Installation is easy:
> PM > Install WpfModernFlat

#Usage
When you want to use this theme, you should **reference Global.xaml** within your window, and **bind your window's Style property to FlatWindowStyle**. I know, it's a bit tedious to manually set the window's style, but whatever. We can fix that later if it's too hard. Your window should be a **WpfModernFlat.Controls.FlatWindow**, of course. If you use the FlatWindow without the style, you'll end up with a window with a black pit where there should be controls.

Anyways, feel free to use it in your projects, or to modify it. I would certainly appreciate any feedback, as I will probably use and expand it in the future, and I want it to become the best it possibly can be. Thanks in advance.
