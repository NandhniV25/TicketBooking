create procedure CreateSeats @sectionId int, @rows int, @cols int
	as
		declare @secId int = @sectionId, @row int= @rows, @col int=@cols
			while @row > 0
			begin
				set @col = @cols
				while @col > 0
				begin
					insert into Seats values(@secId,@row,@col)
					set @col = @col-1
				end
				set @row = @row - 1
			end

exec CreateSeats @sectionId = 4, @rows = 5, @cols = 5
select * from Seats

