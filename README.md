polymermvc
==========

Sample ASP.NET MVC4 application showing how to use Polymer.JS/Bootstrap and Angular.JS to make web components in an MVC4 project

This is a simple ASP.NET MVC4 project, set up to use the new Polymer.JS platform stubs from google.

It's set up to show you a different way of creating re-usable web components in an MVC app and is designed to
accompany my blog post which can be found here:

http://shawtyds.wordpress.com/2013/12/24/2013-year-end/

It demonstartes the simple core concepts of creating shadow dom enabled components that are portable from
one MVC platform to another, and that rely entirely on HTML5 & Javascript to do thier thing.

The techniques used here require no complex setup's to allow your JS code to be sliced up and only included
in the partials thier used in, or anything like that.  You'll see that everything is driven directly from plain
single view files, using the polymer method of loading these components.

Don't worry either if your browser doesn't yet fully support shadow dom, web components and HTML imports, polymer
will make this work right now today (With some other new H5 goodies too) and will adapt itself to use the actual
implemented specifications in any browser that supports it.

Beacuse of the HTML5 requirement, this lot wont work in anything less than IE9, and works great in all of the
current up to date versions of the "Other Browsers"

Iv'e tested this in the following:
Chrome - 31.0.1650.63 m
Firefox - 26.0
Maxthon - 4.1.3.5000
IE - 11.0.2

Polymer and all it's parts is still in an early alpha stage at present, and you may find some bugs in the way
things work.

For the most part however, everything has worked well for me.

If you use chrome://flags in your chrome browser, then scroll down and look for experimental web features
then enable that, you'll get the actual shadow dom stuff enabled.  AT the same time you might also want
to enable the "HTML Imports" flag too.  I did that (THe HTML Imports) however and found that the menu on the main
polymer project site didn't work, so I disabled the imports (So I could read the docs) then re-enabled it
afterwards.

As I learn to do new things with all this, I will update this repo as I progress, and I might even when I get time
convert all the "Bower" packages to work from NuGet.

I also intend to make a PHP/Laravel version of this project, just to demonstrate that this stuff is easily cross
platform enabled, but it may be a little while before I get there....

In the mean time, if you make any improvments or changes please feel free to send a pull request, let's all
try to use this stuff to make MVC much easier and more encapsualted to use.

Shawty
