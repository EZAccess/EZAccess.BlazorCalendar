namespace EZAccess.BlazorCalendar;

public class CalendarItem
{
	public object Id { get; set; } = default!;
	public DateTime TimeStart { get; set; }
	public DateTime TimeEnd { get; set; }
	public string Title { get; set; } = string.Empty;
	public string Description { get; set; } = string.Empty;
}
