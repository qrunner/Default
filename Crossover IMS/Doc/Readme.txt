Visual Studio Solution <Crossover.AMS> contains some fragments of system propotype:

Crossover.AMS.Architecture - System design diagrams
Crossover.AMS.Contracts - Interfaces of some system components (Communication, Authentication, CrisisManagement, Messaging, Notification).
Crossover.AMS.CrisisManagement.Admin - Web Application for populating core system database.
Crossover.AMS.Dashboard - Main Web Application (presentation level) to implement.
Services\Crossover.AMS.Communication - Implementation of Communication service. WCF, EntityFramework, SqlServerLocal.
Services\Crossover.AMS.Communication.Server - Simple Host for testing Communication Service.
Services\Crossover.AMS.Communication.Server.Test - Unit tests for testing Communication Service.
Services\Crossover.AMS.CrisisManagement - Domain Model of core workflow component.
Services\Crossover.AMS.Membership.Ldap - Implementation of LDAP Authentication Component.

The database structure for Crossover.AMS.Communication and Crossover.AMS.CrisisManagement components in this prototype are generates with Entity Framework Code First approach.

Some of Missing requirements:
1)	Employee database structure managed by HR application. 
2)	API of logistics web service exposing ticketing system.
3)	Kind of profile details are stored at the LDAP directory. We assume that it is SID, login, full name and e-mail.
4)	Full list of activities, need to be stored to corporate auditing service.
5)	Security requirements.


Some of things To Do:

Authentication in Communication Service
Ajax-based communication widget
Integration with external systems
Develop scalabulity politics 
Localization support

...And much more, which was not impossible to implement in this short time :)
