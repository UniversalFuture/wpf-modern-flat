# wpf-modern-flat v2.0 Development Roadmap

*	FlatWindow
	*	FlatWindows and styles will work out of the box. There will be no
		additional configuration necessary to get going.
	*	Resizing
		*	Styled ResizeGrips?
	*	Right Titlebar Actions
	*	Option to not show an icon in the titlebar
	*	Minimize, Maximize and Close buttons can be individually hidden
		* Can also have a custom onhover color
*	TabControls
	*	Vertical
	*	Improved support for left and right content
	*	IconVisual color will always match ForeColor
	*	Reorganizable tabs? Think Chrome
* 	New UITypes - Turquoise, Purple and Orange.
* 	Will include Templarian's Modern UI Icons
* 	Inputs
	*	Secondary inputs - Will have a subtler style and receive less
		emphasis within the GUI.
	*	New Inputs
		*	Progressbars
		*	PasswordBox
		*	DateTimeBox - An input that opens a DateTimePicker upon clicking
		*	PatternBox - An input that forces input to match a Regex
		*	Slider and RangeSlider
		*	NumericUpDown
	*	Placeholders
	*	Attached inputs - will remove corresponding borders to provide an
		"attached" look
	* 	"Togglers"
*	Buttons
	* 	Will fix the corners of Primary buttons
	* 	IconButtons will contain an IconVisual and nothing else
	*	Will support toggling through styles for the Checked property
	*	Rounded and circular buttons
	
*	Modals
	* 	Special windows that fade in and out
	*	Actions - right-floated content in a Stackpanel at the bottom
	*	Special implementations - MessageBox, Prompt box, Progress Dialog
*	Compatibility with .NET 3.5 - ***if possible***
*	Extension Methods
	*	Fade in and out
	*	Growth and shrinking
	* 	Rotation
	*	Slide off window - up, left, down, and right
	*	Jiggle
* 	FlatMenu
* 	Roulettes
*	Flyouts
* 	Scrollviewers
*	Ratings
* 	Treeviews - *on steroids*
*	Datagrids - *also on steroids*
*	Dockers? Think "IDE"
*	Dropdowns
	* 	Similar to Semantic UI dropdowns, allow for rich content
	
#Customization

As usual, complete customization will be possible. Alternatively, you can
bind your controls' UIType attributes to a single setting and consistently
style your whole application with a few clicks.