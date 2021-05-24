namespace StudentRecordsSystem
{
	public interface IWelcomeScreen
	{
		/// <summary>
		/// Gets or sets the complete flag.
		/// </summary>
		bool IsComplete { get; }

		/// <summary>
		/// Closes the welcome screen.
		/// </summary>
		/// <remarks>
		/// When implemented on a form, the existing Close method
		/// will fulfill this role.
		/// </remarks>
		void Close();
	}
}