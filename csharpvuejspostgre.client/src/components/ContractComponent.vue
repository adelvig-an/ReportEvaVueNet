<template>
  <div class="contract-manager">
    <h1>Contract Management</h1>

    <form @submit.prevent="saveContract" class="contract-form">
      <h2>{{ editingContract.id ? 'Edit Contract' : 'Add New Contract' }}</h2>
      <div class="form-group">
        <label for="contractType">Contract Type:</label>
        <input type="text" id="contractType" v-model="editingContract.contractType" required />
      </div>
      <div class="form-group">
        <label for="contractName">Contract Name:</label>
        <input type="text" id="contractName" v-model="editingContract.contractName" required />
      </div>
      <div class="form-group">
        <label for="contractNumber">Contract Number:</label>
        <input type="text" id="contractNumber" v-model="editingContract.contractNumber" />
      </div>
      <div class="form-group">
        <label for="dateContract">Contract Date:</label>
        <input type="date" id="dateContract" v-model="editingContract.dateContract" required />
      </div>
      <button type="submit" class="save-button">
        {{ editingContract.id ? 'Update Contract' : 'Add Contract' }}
      </button>
      <button type="button" @click="cancelEdit" v-if="editingContract.id" class="cancel-button">
        Cancel
      </button>
    </form>

    <hr />

    <h2>My Contracts</h2>
    <p v-if="contracts.length === 0">No contracts yet. Add one above!</p>
    <ul class="contract-list">
      <li v-for="contract in contracts" :key="contract.id" class="contract-item">
        <div class="contract-details">
          <strong>{{ contract.contractName }} ({{ contract.contractType }})</strong>
          <p v-if="contract.contractNumber">Number: {{ contract.contractNumber }}</p>
          <p>Date: {{ new Date(contract.dateContract).toLocaleDateString() }}</p>
        </div>
        <div class="contract-actions">
          <button @click="editContract(contract)" class="edit-button">Edit</button>
          <button @click="deleteContract(contract.id)" class="delete-button">Delete</button>
        </div>
      </li>
    </ul>
  </div>
</template>

<script setup>
  import { ref, onMounted } from 'vue';

  // API base URL (можно вынести в .env)
  const API_URL = '/Contract';

  const contracts = ref([]);
  const editingContract = ref(createEmptyContract());
  const loading = ref(false);
  const error = ref(null);

  function createEmptyContract() {
    return {
      id: 0,
      contractType: '',
      contractName: '',
      contractNumber: '',
      dateContract: new Date().toISOString().substring(0, 10),
    };
  }

  // --- CRUD Операции через API ---

  async function fetchContracts() {
    loading.value = true;
    error.value = null;
    try {
      const response = await fetch(API_URL);
      if (!response.ok) throw new Error('Ошибка загрузки договоров');
      const data = await response.json();
      // Преобразуем дату в формат YYYY-MM-DD для input type="date"
      contracts.value = data.map(c => ({
        ...c,
        dateContract: c.dateContract ? c.dateContract.substring(0, 10) : '',
      }));
    } catch (e) {
      error.value = e.message;
    } finally {
      loading.value = false;
    }
  }

  async function saveContract() {
    error.value = null;
    try {
      if (editingContract.value.id) {
        // Обновление
        const updateDto = {
          contractType: editingContract.value.contractType,
          contractName: editingContract.value.contractName,
          contractNumber: editingContract.value.contractNumber,
          dateContract: editingContract.value.dateContract,
        };
        const response = await fetch(`${API_URL}/${editingContract.value.id}`, {
          method: 'PUT',
          headers: { 'Content-Type': 'application/json' },
          body: JSON.stringify(updateDto),
        });
        if (!response.ok) throw new Error('Ошибка обновления договора');
        await fetchContracts();
      } else {
        // Создание
        const createDto = {
          contractType: editingContract.value.contractType,
          contractName: editingContract.value.contractName,
          contractNumber: editingContract.value.contractNumber,
          dateContract: editingContract.value.dateContract,
        };
        const response = await fetch(API_URL, {
          method: 'POST',
          headers: { 'Content-Type': 'application/json' },
          body: JSON.stringify(createDto),
        });
        if (!response.ok) throw new Error('Ошибка создания договора');
        await fetchContracts();
      }
      resetForm();
    } catch (e) {
      error.value = e.message;
    }
  }

  function editContract(contract) {
    editingContract.value = {
      ...contract,
      dateContract: contract.dateContract ? contract.dateContract.substring(0, 10) : '',
    };
  }

  async function deleteContract(id) {
    if (!confirm('Are you sure you want to delete this contract?')) return;
    error.value = null;
    try {
      const response = await fetch(`${API_URL}/${id}`, { method: 'DELETE' });
      if (!response.ok) throw new Error('Ошибка удаления договора');
      await fetchContracts();
      resetForm();
    } catch (e) {
      error.value = e.message;
    }
  }

  function resetForm() {
    editingContract.value = createEmptyContract();
  }

  function cancelEdit() {
    resetForm();
  }

  onMounted(fetchContracts);
</script>

<style scoped>
  .contract-manager {
    max-width: 800px;
    margin: 20px auto;
    padding: 20px;
    border: 1px solid #ccc;
    border-radius: 8px;
    font-family: sans-serif;
    box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
  }

  h1, h2 {
    color: #333;
    text-align: center;
    margin-bottom: 20px;
  }

  hr {
    border: 0;
    height: 1px;
    background: #eee;
    margin: 30px 0;
  }

  /* Form Styles */
  .contract-form {
    background-color: #f9f9f9;
    padding: 20px;
    border-radius: 8px;
    margin-bottom: 30px;
  }

  .form-group {
    margin-bottom: 15px;
  }

    .form-group label {
      display: block;
      margin-bottom: 5px;
      font-weight: bold;
      color: #555;
    }

    .form-group input[type="text"],
    .form-group input[type="date"] {
      width: calc(100% - 20px);
      padding: 10px;
      border: 1px solid #ddd;
      border-radius: 4px;
      font-size: 16px;
    }

  .save-button, .cancel-button {
    background-color: #28a745;
    color: white;
    padding: 10px 20px;
    border: none;
    border-radius: 5px;
    cursor: pointer;
    font-size: 16px;
    margin-right: 10px;
    transition: background-color 0.3s ease;
  }

    .save-button:hover {
      background-color: #218838;
    }

  .cancel-button {
    background-color: #6c757d;
  }

    .cancel-button:hover {
      background-color: #5a6268;
    }

  /* Contract List Styles */
  .contract-list {
    list-style: none;
    padding: 0;
  }

  .contract-item {
    display: flex;
    justify-content: space-between;
    align-items: center;
    background-color: white;
    border: 1px solid #e0e0e0;
    border-radius: 8px;
    padding: 15px;
    margin-bottom: 10px;
    box-shadow: 0 1px 3px rgba(0, 0, 0, 0.05);
  }

  .contract-details {
    flex-grow: 1;
  }

    .contract-details p {
      margin: 5px 0;
      color: #666;
    }

    .contract-details strong {
      color: #333;
    }

  .contract-actions button {
    padding: 8px 12px;
    border: none;
    border-radius: 4px;
    cursor: pointer;
    font-size: 14px;
    margin-left: 10px;
    transition: background-color 0.3s ease;
  }

  .edit-button {
    background-color: #ffc107;
    color: #333;
  }

    .edit-button:hover {
      background-color: #e0a800;
    }

  .delete-button {
    background-color: #dc3545;
    color: white;
  }

    .delete-button:hover {
      background-color: #c82333;
    }
</style>
