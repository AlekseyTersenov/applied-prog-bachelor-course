load "Line.rb"

class CalculateCrossingPoint

	def get_crossing(l1, l2)

		unless (l1.eql?(l2))

			if (l1.one.eql?(l2.two))
				return l1.one
			elsif (l1.two.eql?(l2.one))
				return l1.two
			end

			a1 = l1.one.y - l1.two.y
            b1 = l1.two.x - l1.one.x
            c1 = l1.one.x * l1.two.y - l1.two.x * l1.one.y

            a2 = l2.one.y - l2.two.y
            b2 = l2.two.x - l2.one.x
            c2 = l2.one.x * l2.two.y - l2.two.x * l2.one.y

			if (a1 * b2 - a2 * b1 == 0)
				puts "Прямые параллельны"
				return nil
			else
				y = (a2 * c1 - c2 * a1) / (b2 * a1 - a2 * b1)
                x = (-b1 * y - c1) / a1

				return Point.new(x, y)
			end

		else
			puts "Бесконечное количество точек пересечения"
			return nil
		end

	end
end