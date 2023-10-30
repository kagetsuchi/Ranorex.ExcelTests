# Ranorex.ExcelTests
Sample Automation Tests using Microsoft Excel

## Test Cases:
- Launch Excel
- Create Workbook
- Search Cells
- Add Formula and Check Computation
- Insert/Delete/Copy Cells, Rows and Columns
- Save Workbook ensuring Prompt Message

## Requirements/Configuration
- Excel Version Office 365 (2019). (There's a high possible chance that these test cases will not work on Office 2019 only)
- Ranorex Solution is only configured for single instance
- Use Cache was turned off on repository
- All test cases are unchecked please run a single test case only for each functions

## How to Test each Test Cases:

**1. Launch Excel (Recording Module)**
```
- Launches excel application using default ranorex feature
- Check the Test Case "Launch_Excel" and Run the test individually
```
    
**2. Create Workbook (Recording Module)**
```
- Creates Excel Workbook with default filename
- Filename can be configured under test case's parameters
- Check the Test Case "CreateWorkbook" and Run the test individually
- View test details on report generated
```

**3. Search Cells (Recording Module + Code Module)**
```
- Opens Excel file via Recording module then runs a Code module to select specific cells.
- Then after selecting, it navigates to the next cell.
- Cells to be selected and filename can be configured at test case's parameters
- Check the Test Case "SearchCells" and Run the test individually.
- View test details on report generated
```

**4. Add Formula and Check Computation (Recording Module + Code Module)**
```
- Creates Excel File with values and formula via User Code
- 3 grouped modules that do the following tests:

  - Change cell with a valid value and validate expected result
  - Change with new formula and validate the expected result
  - Change cell with an invalid value and validate the expected result

- Smart folder to validate the captured cell value
- Parameters for Test Case and Modules are separated depending on their usage
- Check the Test Case "AddFormulaCheckCalculation" and Run the test individually.
- View test details on report generated
```

**5. Insert/Delete/Copy Cells, Rows and Columns (Recording Module + Code Module)**
```
- Uses recording modules to create and save excel file including adding data manually
- Values to add are configured on Test Case's parameters
- For insert/delete/copy, a code module is being used and manipulates the running excel application via Ranorex SDK
- Check the Test Case "Cells_InsertDeleteCopy" and Run the test individually.
- View test details on report generated
```
    
**6. Save Workbook ensuring Prompt Message (Recording Module + user-code)**
```
- Re-used recording modules on test cases to create / save and add values on excel file
- Used Ranorex Automation helpers to detect popups in order to provide a report if dialog box appears
- Excel Filename is the only parameter that can be configured in this test case.
- Check the Test Case "Cells_InsertDeleteCopy" and Run the test individually.
- View test details on report generated
```

## Dev Notes
- _I double checked all the elements used on this solution to make sure no content id was used as it is not recommended for testing on a different device._
- _If finding the element still takes too long please recommend any workarounds other than modifying the xPath_
