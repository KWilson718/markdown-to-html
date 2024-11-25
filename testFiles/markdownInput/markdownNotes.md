# Markdown Editor Tests Tests

## Headers:

# Should Be H1

## Should Be H2

### Sould be H3

#### Should be H4

##### Should be H5

###### Should be H6

Alternate Heading 1
=====

Alternate Heading 2
-----

## Paragraph Testing:

This should just be a standard section of paragraph quotes.<br>
The BR tag used should make this a linebreak  
Though this two spaces should also work to do so.

This should appear in a different paragraph from above, since there is an empty line between the text above and this

These two lines
should be merged into one, since there is no breakpoint going on

## Bold Testing:

Text should be **bold** here

Text should also be __bold__ here

Text shouldn't care about spaces when considering if**bold**or not

## Italic Testing:

Italicized text is the *cat's meow*.

Italicized text is the _cat's meow_.

A*cat's*meow.

## Testing Both:

There should be ***italics & bold*** here

There should be ___italics & bold___ here

There should be***italics & bold***here

# Block Quotes:

> This is a single line block quote

> These quotes Can Span Multiple Lines
>
> So Long as there is the correct mark in between the lines
>
> This should prove it to be true

> Nested Block Quotes can also take place
>
> Basically, all one needs to do is make multiple of the symbol in a row rather than just one
>
>> This is an example here
>>
>> Now it's interesting to see how far it goes
>>
>>> It can go even deeper
>>>> Test
>>>>> Test
>>>>>> Test
>>>>>>> Test
>>>>>>>> Test
>>>>>>>>> Test
>>>>>>>>>> Test
>>>>>>>>>>> Test
>>>>>>>>>>>> Test
>>>>>>>>>>>>> Test
>>>>>>>>>>>>>> Test
>>>>>>>>>>>>>>> Test
>>>>>>>>>>>>>>>> Test
>>>>>>>>>>>>>>>>> Test
>>>>>>>>>>>>>>>>>> Test
>>>>>>>>>>>>>>>>>>> Test
>>>>>>>>>>>>>>>>>>>> Test
>>>>>>>>>>>>>>>>>>>>> Test
>>>>>>>>>>>>>>>>>>>>>> Test
>>>>>>>>>>>>>>>>>>>>>>> Test
>>>>>>>>>>>>>>>>>>>>>>>> Test
>>>>>>>>>>>>>>>>>>>>>>>>> Test
>>>>>>>>>>>>>>>>>>>>>>>>>> Test
>>>>>>>>>>>>>>>>>>>>>>>>>>> Test
>>>>>>>>>>>>>>>>>>>>>>>>>>>> Test
>>>>>>>>>>>>>>>>>>>>>>>>>>>>> Test
>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> This is an extreme case
>
> - There can be other elements in BlockQuotes
> - This list can exist quite easily
>
> # How About this Header
>
> - This is an interesting concept to think about porting over  

## Lists:

### Ordered Lists:

1. Ordered Lists can be done by
2. using numbers at the start of the line followed by a period
3. They typically use ascending numbers
5. The numbers are not required to be ascending however, which is interesting
   1. There can be nested lists too
      1. They can go
         1. Quite 
            1. deep
6. The indentations are used to show the depth of nested lists
7. One interesting thing about lists is that they need to be integers. Something like 
8.5 doesn't form a new line, but instead gets appended to the previous line. 

### Unordered Lists:

- unordered lists follow a similar format, however they are just without an order
- These lists can be formed with -, *, or + at the start of a line
  - They can also get indented into
    - Various depths of nesting

### Additional List Notes

- Lists can be broken by something between the lines

    This is done by having a line between a list and the non-listed item

- Additionally, the non-listed item must begin with a tab to show indentation. It then matches up indentation with the rest of the items

    > Additionally, BlockQuotes can be placed in the midst of lists as well

- This all is quite useful for various formatting of information

        <html>
            <head>
                <title>Test<title>
            <head>
        <html>

- When placing in Code Blocks, they're already typically done with a single layer of indentation, so placing them into a list requires two levels of indentation to make it happen. 
  - As an aside, one indentation is equivalent to four spaces in Markdown formatting
- Images follow the same format as above, however this is a more complex feature since the image itself will need to be linked. 
    1. Additionally, 
    2. different
    3. types
    4. of
    5. lists
- Can be inserted into other lists, so a unordered list can also contain an ordered list within it

## Code

Code is typically written with a set of back ticks ` being used to encapsulate them

`cout << "Hello World!!!" << endl;` is an example

Additionally, if there are a set of backticks within the code (such as Javascript's string formatting), then one can use a set of double backticks to make it happen

``let testString = `The value of this is ${immense}``

Multi-line code blocks can happen too

``
let testString = `The value of this is ${immense}
console.log(testString)
``

- Markdown will format this all into a single line following other various conventions too.
- Extra lines in between the different code blocks formatted this way will break the formatting
  - This is why Code Blocks are useful

CodeBlocks are done by Indenting something by one tab
    
    let testVar = true;

    if(testVar) {
        console.log("Hello World!");
    }

One detail to keep in mind is that it can easily accidently merge into a list, in which case it needs to be indented twice rather than just once



## Lines (Horizontal Rules)

One can insert various lines into a document in order to break up sections by doing the following

- write a line of either ***, ---, or ____ on its own line when isolated from other items
- See examples below

---

___

***

The minimum characters needed to do this are three of the same character on its own line

## Links

A link can be done by using a title element and then the link itself

Links by themselves just need to be surrounded by (), such as (https://kwilson718.github.io)

More commonly, titles can be added using the following format:

The title element is done by enclosing a piece of text in [ ]
The link is done by placing it in ()

Put together it forms something like this

My portfolio website is found [Here](https://kwilson718.github.io)

If one needs it to quickly be turned into a link without a title, and doesn't want the () showing up, use angle brackets instead (<>)

<https://kwilson718.github.io>

the same can be done with emails

<johnsmith@test.co>

The links/emails can also be bolded or italicized too

*<johnsmith@test.co>*

**<johnsmith@test.co>**

***<johnsmith@test.co>***

Additionally, there is a way to keep readability focus while inserting a link in the middle of a paragraph. It can be quite useful to have a link inserted in a reference style, while also then having the formal reference written down later on in the document. To do this, use two sets of [] brackets in a paragraph to create the link itself, the first one being the title followed by an identifier number. An example is [here][1] which can be separated by a space or not. To then add in the reference later on, one needs to use a [] followed by a :, followed by a space and then the link itself. There can then be an additional information piece added using something like quotation marks. Lastly, the formally generated link in this reference piece can optionally be surrouned by angle brackets, however it isn't required.

[1]: https://kwilson718.github.io "This is additional information that pops up when the link is hovered over"

This can also be done within blockquotes and the likes



## Images

Images can be added by doing the following

- using an exclamation mark first
- Using a Square Brackets to add some commentary text
- Following that with () containing the file path and some text in quotes
- Optionally, this can all be put in the square brackets of a link section, followed by the link in () to make it link somewhere

An example is below

![A Cat Image that is AI Generated](CatImage.jpg)

It can get linked with:

[![A Cat Image that is AI Generated](CatImage.jpg)](https://kwilson718.github.io)

## Escaping Characters

There are the various examples of characters which have a specific meaning attached to them, all of which might then want to be used in a different context without the formatting being applied. 

A backslash can be used to display them

- \\
- \`
- \*
- \_
- \{
- \}
- \[
- \]
- \<
- \>
- \(
- \)
- \#
- \+
- \-
- \.
- \!
- \|

## HTML

There should be HTML Compatability for some of the most basic things when formatting from Markdown into HTML, the key here is to not mess it up with code blocks, or throw extra tags around the place too...

Not every Markdown document viewer uses HTML tags, so it's something to keep in mind

Many Markdown applications allow you to use HTML tags in Markdown-formatted text. This is helpful if you prefer certain HTML tags to Markdown syntax. For example, some people find it easier to use HTML tags for images. Using HTML is also helpful when you need to change the attributes of an element, like specifying the color of text or changing the width of an image.

To use HTML, place the tags in the text of your Markdown-formatted file.

This **word** is bold. This <em>word</em> is italic.
The rendered output looks like this:

This word is bold. This word is italic.

For security reasons, not all Markdown applications support HTML in Markdown documents. When in doubt, check your Markdown application’s documentation. Some applications support only a subset of HTML tags.

Use blank lines to separate block-level HTML elements like `<div>`, `<table>`, `<pre>`, and `<p>` from the surrounding content. Try not to indent the tags with tabs or spaces — that can interfere with the formatting.

You can’t use Markdown syntax inside block-level HTML tags. For example, <p>italic and **bold**</p> shouldn’t work.

