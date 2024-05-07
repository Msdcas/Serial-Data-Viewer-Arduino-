Little experience. contains shitty code.

I'll translate it into English soon

input serial message format
	*ij_k*
		где 
		* - символ разделитель сообщений
		i - номер области отрисовки (номер графика где будет рисоваться кривая)
		j - номер кривой
		k - значение кривой
		* - в тексте и в комментариях кода мы называем параметры ij - инструкцией
		
	*tij_<string>*
	где префикс "t" - обозначает, что будет задано имя кривой
	<string> - имя кривой
	
	*cij_<color>
	где префикс "с" - обозначает, что будет задан цвет кривой. 
	<color> - цвет. Доступны все значения цветов из пространства .NET представленные в строковом эквиваленте
	(т.е. Black, White, Green, Yellow и пр.)
	
	*sij_<symbolType>
	где префикс "s" - обозначает, что будет задан тип отображения точек кривой
	<symbolType> - стиль отображения точек. Доступны все значения из пространства имен ZedGraph.SymbolType:
	Square, Diamond, Triangle, Circle, XCross, Plus, Star, TriangleDown, HDash, VDash, UserDefined, Default, None
	
формат сообщения для Label
	*Pi_<preamble>*
	где P - обозначает что будет установлена тектовая преамбула (для отображения данных типа: "Скорость = 52", где преамбула есть "Скорость = ")
	i - номер Label (0 - 5)
	<preamble> - текст преамбулы
	
	*Vi_k*
	где V - обозначает, что будет задано значение, которое следует отобразить после преамбулы
	i - номер Label (0 - 5)
	k - отображаемое значение
	
	
	
 Install-Package -Source C:\Users\username\Downloads\ ZedGraph -Scope CurrentUser
