namespace Fibonacci
{
	/// <summary>
	/// Число Фибоначчи.
	/// </summary>
	internal struct Number
	{
		private int _previous;
		private int _current;

		public Number()
		{
			_previous = -1;
			_current = 1;
		}

		/// <summary>
		/// Значение числа Фибоначчи.
		/// </summary>
		internal int Value => _current;

		/// <summary>
		/// Следующее число Фибоначчи.
		/// </summary>
		internal Number Next => new Number
		{
			_previous = _current,
			_current = _previous + _current,
		};
	}
}
