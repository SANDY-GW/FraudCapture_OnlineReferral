Feature: FraudCapture_GeneralTests

A short summary of the feature
Scenario Outline: 01_User_Can_Login 
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page

Examples:	
	| UserEmail                         |
	| yamuna.c@gainwelltechnologies.com |


Scenario Outline:02_AMA_Appears 
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page for General Test:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page for General Tests
And I click on the I Agree button on the fraud capture Page for General Tests

Examples:	
	| UserEmail                         |
	| yamuna.c@gainwelltechnologies.com |

Scenario Outline:03_Default_Landing_Page_Appears 
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

Scenario Outline:04_Can_Switch_Payor
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page for General Test:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page for General Tests
And I click on the I Agree button on the fraud capture Page for General Tests
#And I can switch the Payor fraud capture Page for General Tests
#| PayorName |
#| <PayorName> |

Examples:	
	| UserEmail                         | PayorName   |
	| yamuna.c@gainwelltechnologies.com | Demo Client |

Scenario Outline:05_Settings_Works
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

Scenario Outline:06_User_Can_Logout 
Given when I open the Fraud Capture application
When I enter the "<UserEmail>" on the welcome fraude capture page for General Test:
| UserEmail |
| <UserEmail> |
And I click on the Procced to login button on the welcome fraude capture page for General Tests
And I click on the I Agree button on the fraud capture Page for General Tests
And I click Logout Option to close the Fraud Capture Application successfully
| UserOption   |
| <UserOption> |

Examples:	
	| UserEmail                         | UserOption |
	| yamuna.c@gainwelltechnologies.com | Log Out    |

Scenario Outline:07_Can_View_Help_Article
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


Scenario Outline:08_Alerts_And_Exports_Works
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