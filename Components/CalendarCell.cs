using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZAccess.BlazorCalendar.Components;

internal class CalendarCell
{
	public DateTime Date { get; set; }
	public IEnumerable<CalendarItem> CalendarItems { get; set; } 

	public CalendarCell()
	{
		CalendarItems = [];
	}

	public CalendarCell(DateTime date, IEnumerable<CalendarItem> calendarItems)
	{
		Date = date;
		CalendarItems = calendarItems;
	}

}
