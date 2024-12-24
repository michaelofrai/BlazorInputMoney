# InputMoney.  Currency Input Component.

Example Usage:

`<InputMoney @bind-Value="myMoney"/>`

Parameters:

| Syntax | Notes |
| ------- | -------- |
| @bind-Value="decimal var"  | Normal binding. |
| DecimalDigits="n"      | Defaults to 2. |
| SelectOnFocus="true"    | Select on field entry. |
| NumberFormatInfo="var"  | Number format object. |
| `Others`                | Applied to <input> element as attributes. |

Default style:

`"font-weight:bold;text-align:right;" `

More complex example:

`<InputMoney @bind-Value="myMoney"
    style="font-weight:normal" class="w-50"
    DecimalDigits="3"/>`

[Here's a screenshot: ] (https://github.com/michaelofrai/BlazorInputMoney/blob/master/InputMoney%20Examples.pdf)

Note:  The example (program.cs) uses the culture from the browser.
