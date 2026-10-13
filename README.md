# SecureHR Sync

A platform for full-stack employee data migration that demonstrates enterprise software engineering principles, validation, reconciliation, and privacy-aware processing.

> Project Status: Planning and early development

## Problem

Organisations migrating employee information between systems face risks such as:

- Missing employee records
- Duplicate data
- Invalid or incompatible formats
- Incorrect data transformations
- Failed migrations
- Exposure of sensitive personal information

## Who Is It For?

The primary user is a data migration specialist or authorised administrator responsible for preparing, validating, migrating, and verifying employee data.

## MVP Features

- CSV employee data upload
- Employee data preview
- Required-field validation
- Duplicate employee detection
- Validation error reporting
- Migration of valid records
- Failure tracking
- Basic reconciliation

## Technology Stack

### Frontend
- React
- JavaScript
- HTML
- CSS

### Backend
- C#
- ASP.NET Core Web API

### Data
- SQL Server
- Entity Framework Core
- CsvHelper

### Testing
- xUnit

## Planned Architecture

CSV - React - ASP.NET Core API - Services - Entity Framework Core - SQL Server

## Known Limitations

- CSV source only
- Simulated HR environment
- No direct SAP integration
- Synthetic employee data only
- Not a full HR/HCM system

## Future Improvements

- Transformation rules
- Data masking
- Migration history
- Audit logs
- Authentication
- Role-based access
- Dashboard
- Cloud deployment

## Author

Krisha Gandhi
