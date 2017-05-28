load "Point.rb"

class Line

	attr_accessor :one, :two

	def initialize()
		@one = Point.new()
		@two = Point.new()
	end

	def init()
		puts "Координаты первой точки : "
		print "x="
		@one.x = readline().to_f()
		print "y="
		@one.y = readline().to_f()

		puts "Координаты втрой точки : "
		print "x="
		@two.x = readline().to_f()
		print "y="
		@two.y = readline().to_f()
	end

	def eql?(point)

		if ((@one.eql?(point.one) && @two.eql?(point.two)) || (@one.eql?(point.two) && @two.eql?(point.one)))
			return true
		else
			return false
		end

	end

end