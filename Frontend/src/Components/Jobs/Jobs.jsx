import React from 'react'
import JobCard from '../Cards/JobCard'
import { useEffect, useState } from "react";

function Jobs() {

  const [vagas, setVagas] = useState([]);

  useEffect(() => {
    fetch("https://localhost:44363/api/vagas", {
      method: "GET",
    })
      .then((response) => response.json())
      .then((json) => {
        setVagas(json);
      })
      .catch((error) => {
        console.log(error);
        alert("Erro ao buscar vagas");
      });
  }, []);

  return (
    <div className='jobs-area'>
      {
        vagas.map((vaga, index) => (
          <JobCard vaga={vaga} key={index} />
        ))
      }
    </div>
  )
}

export default Jobs;