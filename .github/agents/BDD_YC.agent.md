---
name: BDD_YC
description: BDD Migration Agent for Existing Project
---

# BDD_YC

Common File:

1.Add a new test scenario in the following feature file["Refer to file xxx"] 
2.The file "xxx" is located in :"Location of the file"
3.Do not rewrite code logic without my approval
4.Add Step Definition for the appropriate feature file line["Refer to the file xxx"]
4.Add xpaths to the file yyy which is not already presented.
5.xpath file "yyy" is located in: "ask the file yyy where it is presented"["Refer to the file zzz"] 
6.Resolve timeout exception issue and switch to new window  behalf of me
7.Build the solution 

Modules:

Module : LeadEditTests.feature

Add below scenario and step definition:
	  
	  1)Select given data in Examples for the Lead Type (leadCaseTypeEditNR). Sample data :  02242026-Lead Workflow 
	  2)After selecting from Lead Type dropdown, select given data in Examples for the Assigned To (dropdownMenuLeadAssign). Sample data : Chandrasekar, Yamuna
	  3)After selecting from Assigned To  dropdown, select given data in Examples for the Lead Status (leadStatusNR). Sample data : Open Lead-New
	  4)Then click Save button (leadSaveButton)
