<template>
  <div>
    <div class="text-gray-900 bg-gray-200">
      <div class="p-4 flex">
        <h1 class="text-3xl">Estudiantes</h1>
      </div>
      <div class="md:m-4">
        <form class="inline w-full">
          <div class="bg-white shadow-md rounded px-8 pt-6 pb-8">
            <div class="flex justify-between flex-wrap -mx-3 mb-6">
              <div class=" w-1/4 px-3">
                <label class="font-bold block text-gray-700 text-sm mb-2 my-2" for="grid-first-name">ID Curso</label>
                <input class="appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500" type="text" placeholder="ID Curso">
              </div>
              <div class=" w-1/4 px-3">
                <label class="font-bold block text-gray-700 text-sm mb-2 my-2" for="grid-first-name">Nombre</label>
                <input class="appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500" type="text" placeholder="Dioris">
              </div>
              <div class=" w-1/4 px-3">
                <label class="font-bold block text-gray-700 text-sm mb-2 my-2" for="grid-last-name">Apellido</label>
                <input class="appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500" type="text" placeholder="Rojas">
              </div>
            </div>
            <div class="flex justify-between flex-wrap -mx-3 mb-6">
              <div class=" w-1/4 px-3">
                <label class="font-bold block text-gray-700 text-sm mb-2 my-2" for="grid-first-name">Sexo</label>
                <input class="appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500" type="text" placeholder="Masculino / Femenino">
              </div>
              <div class=" w-1/4 px-3">
                <label class="font-bold block text-gray-700 text-sm mb-2 my-2" for="grid-first-name">Edad</label>
                <input class="appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500" type="text" placeholder="18">
              </div>
              <div class=" w-1/4 px-3">
                <label class="font-bold block text-gray-700 text-sm mb-2 my-2" for="grid-last-name">Codigo</label>
                <input class="appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500" type="text" placeholder="2016-001">
              </div>
              <div class=" w-1/4 px-3">
                <label class="font-bold block text-gray-700 text-sm mb-2 my-2" for="grid-last-name">Telefono</label>
                <input class="appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500" type="text" placeholder="xxx-xxx-xxxx">
              </div>
            </div>
            <div class="flex justify-between flex-wrap -mx-3 mb-6">
              <div class=" w-full px-3">
                <label class="font-bold block text-gray-700 text-sm mb-2 my-2" for="grid-first-name">Dirrecion</label>
                <input class="appearance-none block w-full bg-gray-200 text-gray-700 border border-gray-200 rounded py-3 px-4 leading-tight focus:outline-none focus:bg-white focus:border-gray-500" type="text" placeholder="Autopista 30 de Mayo Esq. Heroes de Luperon & Calle Heroes de Luperón, Santo Domingo 10401">
              </div>
            </div>
            <!-- Button -->
            <div class="flex items-center justify-between">
              <button class="bg-blue-500 hover:bg-blue-dark text-white font-bold py-2 px-4 rounded" type="button">Add</button>
            </div>
          </div>
        </form>
      </div>
      <div class="px-3 py-4 flex justify-center my-6">
        <table class="w-full text-md bg-white shadow-md rounded mb-4">
          <tbody>
            <tr class="border-b">
              <th class="p-3">ID</th>
              <th class="p-3">ID Curso</th>
              <th class="p-3">Nombre</th>
              <th class="p-3">Apellido</th>
              <th class="p-3">Sexo</th>
              <th class="p-3">Edad</th>
              <th class="p-3">Codigo</th>
              <th class="p-3">Telefono</th>
              <th class="p-3">Direccion</th>
              <th class="p-3">Accion</th>
              <th></th>
            </tr>
            <tr class="border-b hover:bg-orange-100"  v-for="Estudiante in Estudiantes" :key="Estudiante.idEstudiantes">
              <td class="p-3">{{Estudiante.idEstudiantes}}</td>
              <td class="p-3">{{Estudiante.idCurso}}</td>
              <td class="p-3">{{Estudiante.nombre}}</td>
              <td class="p-3">{{Estudiante.apellido}}</td>
              <td class="p-3">{{Estudiante.sexo}}</td>
              <td class="p-3">{{Estudiante.edad}}</td>
              <td class="p-3">{{Estudiante.codigo}}</td>
              <td class="p-3">{{Estudiante.telefono}}</td>
              <td class="p-3">{{Estudiante.direccion}}</td>    
              <td><button type="button" class="mr-3 text-sm bg-blue-300 hover:bg-blue-700 text-white py-1 px-2 rounded focus:outline-none focus:shadow-outline">Edit</button><button type="button" class="text-sm bg-red-500 hover:bg-red-700 text-white py-1 px-2 rounded focus:outline-none focus:shadow-outline">Delete</button></td>
            </tr>
          </tbody>
        </table>
      </div>
    </div>
  <!-- De ahi hacia abajo no se toca-->
  </div>
</template>


<style>
    
</style>



<script>
import axios from 'axios'
export default {
    name: 'Estudiantes',
    data() {
      return {
        Estudiantes: []
      }
    },
    created() {
    fetch('https://localhost:44375/api/Estudiantes/all')
    .then(response => response.json())
    .then((data) => { this.Estudiantes = data})
  }
}
</script>