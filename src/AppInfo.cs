namespace MoonWorks;

public readonly record struct AppInfo(
	string OrganizationName, string ApplicationName,
	string ApplicationIdentifier, string ApplicationVersion, string Copyright
);

