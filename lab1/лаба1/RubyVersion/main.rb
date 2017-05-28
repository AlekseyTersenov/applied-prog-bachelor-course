load "CalcutateCrossinfPoint.rb"

l1 = Line.new()
l2 = Line.new()

l1.init()
l2.init()


calc = CalculateCrossingPoint.new()
result_point = calc.get_crossing(l1, l2)


unless result_point == nil
	puts "Координаты точки пересечения"
	puts result_point
end