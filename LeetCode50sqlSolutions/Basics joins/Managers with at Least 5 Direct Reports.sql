select name 
from employee em
where (
    select count(*)
    from employee em1
    where em1.managerid = em.id
          ) >= 5