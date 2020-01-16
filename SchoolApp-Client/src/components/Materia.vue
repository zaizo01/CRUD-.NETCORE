<template>
<div class="Materia">
<div class="text-gray-900 bg-gray-200">
<div class="p-4 flex">
<h1 class="text-3xl">Materias</h1>
</div>
 <div class="md:m-4">
        <form class="inline w-full">
          <div class="bg-white shadow-md rounded px-12 pt- pb-6">
            <div class="flex justify-between flex-wrap -mx-3 mb-6">
              <div class=" w-1/4 px-3">
                <label class="font-bold block text-gray-700 text-sm mb-2 my-2" for="grid-first-name">ID Curso</label>
                <input class="appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500" type="text" placeholder="ID Curso">
              </div>
              <div class=" w-1/4 px-3">
                <label class="font-bold block text-gray-700 text-sm mb-2 my-2" for="grid-first-name">Profesor</label>
                <input class="appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500" type="text" placeholder="Dioris">
              </div>
              <div class=" w-1/4 px-3">
                <label class="font-bold block text-gray-700 text-sm mb-2 my-2" for="grid-last-name">Materia</label>
                <input class="appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500" type="text" placeholder="Programación">
              </div>
            </div>
            <div class="flex justify-between flex-wrap -mx-3 mb-8">
              <div class=" w-1/4 px-3">
                <label class="font-bold block text-gray-700 text-sm mb-2 my-2" for="grid-first-name">Horario</label>
                <input class="appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500" type="text" placeholder="Matutino / Vespertino">
              </div>
              <div class=" w-1/4 px-3">
                <label class="font-bold block text-gray-700 text-sm mb-2 my-2" for="grid-first-name">Duracion</label>
                <input class="appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500" type="text" placeholder="Un Año">
              </div>
               <div class="flex items-center justify-between w-1/4 px-3 mb-8 my-10 w-1/4 px-3">
                <button class="bg-blue-500 hover:bg-blue-dark text-white font-bold py-2 px-10 rounded" type="button">Add</button>
              </div>

            </div>    
        </div>
        </form>
      </div>
    <div class="px-3 py-4 flex justify-center">
        <table class="w-full text-md bg-white shadow-md rounded mb-4">
            <tbody>
                <tr class="border-b">
                    <th class="p-3">ID</th>
                    <th class="p-3">ID Curso</th>
                    <th class="p-3">Profesor</th>
                    <th class="p-3">Materia</th>
                    <th class="p-3">Horario</th>
                    <th class="p-3">Duracion</th>
                    <th class="p-3">Accion</th>
                    <th></th>
                </tr>
                <tr class="border-b hover:bg-orange-100" v-for="Materia in Materias" :key="Materia.idMaterias">
                    <td class="p-3">{{Materia.idMaterias}}</td>
                    <td class="p-3">{{Materia.idCurso}}</td>
                    <td class="p-3">{{Materia.profesor}}</td>
                    <td class="p-3">{{Materia.materia}}</td>
                    <td class="p-3">{{Materia.horario}}</td>
                    <td class="p-3">{{Materia.duracion}}</td>
                    
                    <td ><button type="button" class="mr-3 text-sm bg-blue-300 hover:bg-blue-700 text-white py-1 px-2 rounded focus:outline-none focus:shadow-outline">Edit</button><button type="button" class="text-sm bg-red-500 hover:bg-red-700 text-white py-1 px-2 rounded focus:outline-none focus:shadow-outline">Delete</button></td>
                </tr>
            </tbody>
        </table>
    </div>
</div>   
</div>
</template>


<style>
    
</style>




<script>
import axios from 'axios'
export default {
    name: 'Materia',
    data() {
      return {
        Materias: []
      }
    },
    created() {
    fetch('https://localhost:44375/api/Materias/all')
    .then(response => response.json())
    .then((data) => { this.Materias = data})
  }
}
</script>