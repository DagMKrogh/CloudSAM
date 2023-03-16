# User

User is buildt up with information from azure active directory (ad).
User is saved by ID, and we retrieve and update information not used as ID on regular basis (Once pr week on logon).
User object has a buildt inn object refresh that connects to ad.


### Information Fields
User will have:
 - Internal ID (GUID)
 - ObjectID (AD)
 - User Principal Name (AD)
 - Full name (AD)
 - Email (AD)
 - Active
 - CreatedAt (Datetime, ???)
 - UpdatedAt (Datetime, ???)


# System
Systems are created to organize users with roles within some sort of system.
The systems can be fictional with just organization purposes, or it can be integrated with azure ad roles and CloudSAM can manage its application roles.

### Information Fields
System will have:
 - Internal ID (GUID)
 - ObjectID (AD)
 - Full name (AD)
 - Owner (UserID GUID)
 - Active
 - CreatedAt (Datetime, ???)
 - UpdatedAt (Datetime, ???)


# Role
A role is unique to a system, and defined pr system. Each system can therfore define what a role means for it, and how it is handled.