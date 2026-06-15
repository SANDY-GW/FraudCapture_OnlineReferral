Feature: FraudCapture_GeneralTests

A short summary of the feature
#Scenario Outline: User_Can_Login 
#Given when I open the Fraud Capture application to launch the welcome page
#When I enter the "<UserEmail>" on the welcome fraude capture page for General Test:
#| UserEmail |
#| <UserEmail> |
#And I click on the Procced to login button on the welcome fraude capture page for General Tests
#
#Examples:	
#	| UserEmail                         |
#	| yamuna.c@gainwelltechnologies.com |

Scenario Outline: User_Can_Login 
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page
And I click on the I Agree button on the fraud capture Page
And I click on CaseTracking and select the "Leads" option on the fraud capture home page

Examples:	
	| UserEmail                         |
	| yamuna.c@gainwelltechnologies.com |


Scenario Outline:AMA_Appears 
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page for General Test:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page for General Tests
And I click on the I Agree button on the fraud capture Page for General Tests

Examples:	
	| UserEmail                         |
	| yamuna.c@gainwelltechnologies.com |

Scenario Outline:Default_Landing_Page_Appears 
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page for General Test:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page for General Tests
And I click on the I Agree button on the fraud capture Page for General Tests
And I can able to see the Default Landing Page "Case Tracking" of Fraud Capture Application

Examples:	
	| UserEmail                         |
	| yamuna.c@gainwelltechnologies.com |

Scenario Outline:Can_Switch_Payor
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page for General Test:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page for General Tests
And I click on the I Agree button on the fraud capture Page for General Tests
And I can switch the Payor to "<PayorName>" on the fraud capture Page for General Tests
| PayorName |
| <PayorName> |

Examples:	
	| UserEmail                         | PayorName   |
	| yamuna.c@gainwelltechnologies.com | Demo Client |

Scenario Outline:Settings_Works
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page for General Test:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page for General Tests
And I click on the I Agree button on the fraud capture Page for General Tests
And I click Settings options to see the selection of Landing Page Details

Examples:	
	| UserEmail                         |
	| yamuna.c@gainwelltechnologies.com |

Scenario Outline:User_Can_Logout 
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page for General Test:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page for General Tests
And I click on the I Agree button on the fraud capture Page for General Tests
And I click Logout Option to close the Fraud Capture Application

Examples:	
	| UserEmail                         |
	| yamuna.c@gainwelltechnologies.com |

Scenario Outline:Can_View_Help_Article
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page for General Test:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page for General Tests
And I click on the I Agree button on the fraud capture Page for General Tests
And I click Help symbol to see the QuickLinks and click on the User Guide to view the help article in new tab

Examples:	
	| UserEmail                         |
	| yamuna.c@gainwelltechnologies.com |


Scenario Outline:Alerts_And_Exports_Works
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page for General Test:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page for General Tests
And I click on the I Agree button on the fraud capture Page for General Tests
And I click Help symbol to see the QuickLinks and click on the User Guide to view the help article in new tab

Examples:	
	| UserEmail                         |
	| yamuna.c@gainwelltechnologies.com |