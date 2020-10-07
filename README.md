# XCover QA Challenge

**Assumption**

There are only 7 steps to create a quote which are Category, Address, Brand, Model, Retail Value, Buy date and Condition.

Quote details page need more requirements to verify. Currently I only check Proceed button and header.

Using Chrome as default browser as assuming that Chrome is the most used browser.

Assume that the negative cases are covered in other layer of test such as unit test. 

**Suggestions**

Some elements should have data-test-id for easier capture for automation.

In filling address step, we should mention countries we are covering.

DatePicker cannot type

DatePicker control does not provide ability to quick jump to year. 

**Issues**

Some error appears inconsistently such as "Sorry! Something went wrong. Please try again later.", "Unfortunately we cannot provide a quote at this time.".


 